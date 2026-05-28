using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using AsmResolver;
using AsmResolver.DotNet;
using AsmResolver.DotNet.Signatures;
using AsmResolver.PE.DotNet.Metadata.Tables;
using AssetRipper.CIL;
using AssetRipper.Translation.LlvmIR.Extensions;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LLVMSharp.Interop;

namespace AssetRipper.Translation.LlvmIR;

internal sealed partial class ModuleContext
{
	public ModuleContext(
		LLVMModuleRef module,
		ModuleDefinition definition,
		TranslatorOptions options
	)
	{
		HelpersNamespace = options.GetNamespace("Helpers");
		RuntimeImporter = new RuntimeTypeImporter(definition);

		// AssemblyFunctions is a local output-module type (methods are added to it dynamically).
		AssemblyFunctionsType = new TypeDefinition(
			HelpersNamespace,
			nameof(AssemblyFunctions),
			TypeAttributes.NotPublic | TypeAttributes.Abstract | TypeAttributes.Sealed,
			definition.CorLibTypeFactory.Object.ToTypeDefOrRef()
		);
		definition.TopLevelTypes.Add(AssemblyFunctionsType);

		Module = module;
		Definition = definition;
		Options = options;
		GlobalMembersType = CreateStaticType(
			string.IsNullOrEmpty(options.ClassName) ? "GlobalMembers" : options.ClassName,
			true
		);

		CompilerGeneratedAttributeConstructor = (IMethodDefOrRef)
			definition.DefaultImporter.ImportMethod(
				typeof(CompilerGeneratedAttribute).GetConstructors()[0]
			);

		PrivateImplementationDetails = new TypeDefinition(
			null,
			"<PrivateImplementationDetails>",
			TypeAttributes.NotPublic
				| TypeAttributes.AutoLayout
				| TypeAttributes.AnsiClass
				| TypeAttributes.Sealed,
			Definition.CorLibTypeFactory.Object.ToTypeDefOrRef()
		);
		AddCompilerGeneratedAttribute(PrivateImplementationDetails);
		Definition.TopLevelTypes.Add(PrivateImplementationDetails);
	}

	public string? HelpersNamespace { get; }

	/// <summary>
	/// Provides cross-assembly references to all helper/runtime types in
	/// <c>AssetRipper.Translation.LlvmIR.Runtime</c>.  Use the <c>Import*</c> helpers
	/// when passing methods or fields to CIL instructions.
	/// </summary>
	public RuntimeTypeImporter RuntimeImporter { get; }

	/// <summary>Backward-compatible alias for <see cref="RuntimeImporter"/>.</summary>
	public IReadOnlyDictionary<Type, TypeDefinition> InjectedTypes => RuntimeImporter;

	/// <summary>The output-local container for unresolved inline-assembly stub methods.</summary>
	public TypeDefinition AssemblyFunctionsType { get; }

	// ─── Convenience shortcuts (source TypeDefinitions for method/field look-up) ──
	public TypeDefinition IntrinsicsType => RuntimeImporter[typeof(IntrinsicFunctions)];
	public TypeDefinition InlineArrayHelperType => RuntimeImporter[typeof(InlineArrayHelper)];
	public TypeDefinition SpanHelperType => RuntimeImporter[typeof(SpanHelper)];
	public TypeDefinition InstructionHelperType => RuntimeImporter[typeof(InstructionHelper)];
	public TypeDefinition NumericHelperType => RuntimeImporter[typeof(NumericHelper)];
	public TypeDefinition InlineArrayNumericHelperType =>
		RuntimeImporter[typeof(InlineArrayNumericHelper)];

	// ─── Import helpers (delegate to RuntimeImporter) ─────────────────────────
	/// <summary>Import a Runtime <see cref="MethodDefinition"/> into the output module for CIL emit.</summary>
	public IMethodDefOrRef ImportRuntimeMethod(MethodDefinition method) =>
		RuntimeImporter.ImportMethod(method);

	/// <summary>Import a Runtime <see cref="FieldDefinition"/> into the output module for CIL emit.</summary>
	public IFieldDescriptor ImportRuntimeField(FieldDefinition field) =>
		RuntimeImporter.ImportField(field);

	/// <summary>Get a <see cref="TypeSignature"/> referencing a Runtime type.</summary>
	public TypeSignature GetRuntimeTypeSignature(Type type) =>
		RuntimeImporter.GetTypeSignature(type);

	/// <summary>Get an <see cref="ITypeDefOrRef"/> referencing a Runtime type.</summary>
	public ITypeDefOrRef GetRuntimeTypeRef(Type type) => RuntimeImporter.GetTypeRef(type);

	public LLVMModuleRef Module { get; }
	public ModuleDefinition Definition { get; }
	public TranslatorOptions Options { get; }
	public TypeDefinition GlobalMembersType { get; }
	public TypeDefinition PrivateImplementationDetails { get; }
	private readonly Dictionary<string, FieldDefinition> storedDataFieldCache = new();
	private IMethodDefOrRef CompilerGeneratedAttributeConstructor { get; }
	public Dictionary<LLVMValueRef, FunctionContext> Methods { get; } = new();
	private readonly Dictionary<LLVMTypeRef, StructContext> structsCache = new();
	public Dictionary<TypeDefinition, StructContext> Structs { get; } =
		new(SignatureComparer.Default);

	/// <summary>
	/// All enumeration types discovered from DWARF debug metadata, keyed by their DWARF mangled
	/// identifier (e.g. <c>_ZTSN…E</c>). Populated by the metadata processing step.
	/// </summary>
	public Dictionary<string, EnumContext> Enums { get; } = new();
	public Dictionary<LLVMValueRef, GlobalVariableContext> GlobalVariables { get; } = new();
	private readonly Dictionary<(TypeSignature, int), InlineArrayContext> inlineArrayCache = new(
		TypeSignatureIntPairComparer
	);
	public Dictionary<TypeDefinition, InlineArrayContext> InlineArrayTypes { get; } =
		new(SignatureComparer.Default);

	private static PairEqualityComparer<TypeSignature, int> TypeSignatureIntPairComparer { get; } =
		new(SignatureComparer.Default, EqualityComparer<int>.Default);

	public InlineArrayContext GetOrCreateInlineArray(TypeSignature type, int size)
	{
		if (type is PointerTypeSignature)
		{
			type = Definition.CorLibTypeFactory.IntPtr; // Pointers cannot be used as generic type arguments, so we use IntPtr instead.
		}
		(TypeSignature, int) pair = (type, size);
		if (!inlineArrayCache.TryGetValue(pair, out InlineArrayContext? arrayType))
		{
			arrayType = InlineArrayContext.CreateInlineArray(type, size, this);

			inlineArrayCache.Add(pair, arrayType);
			InlineArrayTypes.Add(arrayType.Type, arrayType);
		}

		return arrayType;
	}

	public InlineArrayContext GetContextForInlineArray(TypeSignature arrayType)
	{
		return InlineArrayTypes[(TypeDefinition)arrayType.ToTypeDefOrRef()];
	}

	public void CreateFunctions()
	{
		int count = Module.GetFunctions().Count();
		int i = 1;
		foreach (LLVMValueRef function in Module.GetFunctions())
		{
			if (i % 100 == 0)
			{
				Console.WriteLine($"Creating function {i}/{count}");
			}
			FunctionContext.Create(function, this);
			i++;
		}
	}

	public void AssignMemberNames()
	{
		// Assign names for global variables independently so that functions and globals
		// no longer compete for the same name pool.  Types live in separate namespaces
		// (GlobalFunctions vs GlobalVariables) so same short names never conflict.
		GlobalVariables.Values.AssignNames();
		AssignFunctionNames();
	}

	/// <summary>
	/// Assigns names to all functions and merges the declaring types of non-intrinsic
	/// functions that share the same clean name (i.e. template specialisations of the
	/// same function) into a single <see cref="AsmResolver.DotNet.TypeDefinition"/> so
	/// all their <c>Invoke</c> overloads live in one class.
	/// </summary>
	private void AssignFunctionNames()
	{
		// Split into intrinsics (never merged) and non-intrinsics (candidates for merging).
		List<FunctionContext> intrinsics = [];
		List<FunctionContext> nonIntrinsics = [];
		foreach (FunctionContext fc in Methods.Values)
		{
			(fc.IsIntrinsic ? intrinsics : nonIntrinsics).Add(fc);
		}

		// Intrinsics keep the original hash-suffix collision resolution.
		intrinsics.AssignNames();

		// Non-intrinsics: when all functions in a CleanName group have distinct mangled
		// names they are template specialisations that should share one declaring type.
		List<List<FunctionContext>> pendingMerges = [];

		foreach (IGrouping<string, FunctionContext> cleanGroup in nonIntrinsics.GroupBy(f => f.CleanName))
		{
			string cleanName = cleanGroup.Key;
			List<FunctionContext> functions = [.. cleanGroup];

			if (functions.Count == 1)
			{
				functions[0].Name = cleanName;
			}
			else if (functions.Select(f => f.MangledName).Distinct().Count() != functions.Count)
			{
				// Duplicate mangled names → cannot merge reliably → use hash+index fallback.
				for (int i = 0; i < functions.Count; i++)
				{
					functions[i].Name = NameGenerator.GenerateName(
						cleanName,
						functions[i].MangledName,
						i
					);
				}
			}
			else
			{
				// All distinct mangled names → assign the same clean name to every variant.
				// They will be merged into a single declaring type below.
				//
				// Additional guard: only merge if all Invoke methods would have distinct
				// CIL parameter signatures. When signatures are identical (e.g. multiple
				// specialisations of "TypedInt<int>::operator int()" that all map to
				// "int Invoke(void*)"), the overloads cannot be distinguished in CIL and
				// the merged class would fail to compile → fall back to hash suffixes.
				bool allDistinctSignatures = functions
					.Select(f => GetMethodSignatureKey(f.Definition))
					.ToHashSet(StringComparer.Ordinal)
					.Count == functions.Count;

				if (!allDistinctSignatures)
				{
					for (int i = 0; i < functions.Count; i++)
					{
						functions[i].Name = NameGenerator.GenerateName(
							cleanName,
							functions[i].MangledName,
							i
						);
					}
				}
				else
				{
					foreach (FunctionContext fc in functions)
					{
						fc.Name = cleanName;
					}

					// Sort by mangled name for deterministic canonical ordering.
					pendingMerges.Add(
						[.. functions.OrderBy(f => f.MangledName, StringComparer.Ordinal)]
					);
				}
			}
		}

		// Perform type merges: move all Invoke overloads into group[0]'s declaring type.
		foreach (List<FunctionContext> group in pendingMerges)
		{
			TypeDefinition canonicalType = group[0].DeclaringType;

			// Rename every __pointer field now so they are all unique within the merged type.
			foreach (FunctionContext fc in group)
			{
				if (fc.PointerField is not null)
				{
					fc.PointerField.Name = NameGenerator.GenerateName("__pointer", fc.MangledName);
				}
			}

			// Move functions[1..n] into the canonical type and delete their empty shells.
			for (int i = 1; i < group.Count; i++)
			{
				FunctionContext other = group[i];
				TypeDefinition otherType = other.DeclaringType;

				// Move the Invoke method (AsmResolver auto-updates Definition.DeclaringType).
				otherType.Methods.Remove(other.Definition);
				canonicalType.Methods.Add(other.Definition);

				// Move the __pointer field if it was created.
				if (other.PointerField is not null)
				{
					otherType.Fields.Remove(other.PointerField);
					canonicalType.Fields.Add(other.PointerField);
				}

				// Remove the now-empty shell type from the module.
				Definition.TopLevelTypes.Remove(otherType);
			}
		}

		// Stamp every function's declaring type with the final assigned name.
		// For merged groups all functions share the canonical type so this is idempotent.
		foreach (FunctionContext fc in Methods.Values)
		{
			fc.DeclaringType.Name = fc.Name;
		}
	}

	/// <summary>
	/// Produces a string key that uniquely represents the CIL parameter and return-type
	/// signature of <paramref name="method"/> for use in duplicate-overload detection.
	/// Two methods with the same key cannot coexist as overloads in the same type.
	/// </summary>
	private static string GetMethodSignatureKey(MethodDefinition method)
	{
		var sig = method.Signature;
		if (sig is null)
			return string.Empty;

		static string TypeKey(TypeSignature t) =>
			t.FullName ?? t.ToString() ?? "?";

		var parts = new List<string>(sig.ParameterTypes.Count + 1) { TypeKey(sig.ReturnType) };
		parts.AddRange(sig.ParameterTypes.Select(TypeKey));
		return string.Join(",", parts);
	}

	public void AssignStructNames()
	{
		Structs.Values.AssignNames();
		foreach (StructContext structContext in Structs.Values)
		{
			structContext.AddNameAttributes();
		}
	}

	public void AssignInlineArrayNames()
	{
		InlineArrayTypes.Values.AssignNames();
	}

	public void IdentifyFunctionsThatMightThrow()
	{
		HashSet<string> intrinsicMethodsThatMightThrow = new();
		string attrNs = RuntimeTypeImporter.AttributesNamespace;
		foreach (MethodDefinition method in IntrinsicsType.Methods)
		{
			if (!method.HasCustomAttribute(attrNs, nameof(MightThrowAttribute)))
			{
				continue;
			}

			foreach (
				CustomAttribute attribute in method.FindCustomAttributes(
					attrNs,
					nameof(MangledNameAttribute)
				)
			)
			{
				string? mangledName = attribute.Signature?.FixedArguments[0].Element?.ToString();
				if (mangledName is not null)
				{
					intrinsicMethodsThatMightThrow.Add(mangledName);
				}
			}
		}

		bool anyIntrinsicsUsedThatMightThrow = false;
		foreach (FunctionContext function in Methods.Values)
		{
			if (
				function.IsIntrinsic
				&& intrinsicMethodsThatMightThrow.Contains(function.MangledName)
			)
			{
				function.MightThrowAnException = true;
				anyIntrinsicsUsedThatMightThrow = true;
			}
		}

		if (
			!anyIntrinsicsUsedThatMightThrow
			&& !Methods
				.Values.SelectMany(f => f.Function.GetInstructions())
				.Any(i => i.InstructionOpcode == LLVMOpcode.LLVMInvoke)
		)
		{
			// If no intrinsic methods that might throw are used, and no invoke instructions are present,
			// so we can assume that no function pointer calls might throw exceptions.
			return;
		}

		bool changed;
		do
		{
			changed = false;

			foreach (FunctionContext function in Methods.Values)
			{
				if (function.MightThrowAnException)
				{
					continue;
				}

				foreach (LLVMValueRef instruction in function.Function.GetInstructions())
				{
					if (
						instruction.InstructionOpcode
						is not LLVMOpcode.LLVMInvoke
							and not LLVMOpcode.LLVMCall
					)
					{
						continue;
					}

					LLVMValueRef calledFunction = instruction.GetOperand(
						(uint)(instruction.OperandCount - 1)
					);
					if (calledFunction.IsAFunction != default)
					{
						if (Methods[calledFunction].MightThrowAnException)
						{
							function.MightThrowAnException = true;
							changed = true;
						}
					}
					else
					{
						function.MightThrowAnException = true;
						changed = true;
					}
				}
			}
		} while (changed);

		foreach (FunctionContext function in Methods.Values)
		{
			if (!function.MightThrowAnException)
			{
				continue;
			}

			function.NeedsStackFrame = function
				.Function.GetInstructions()
				.Any(i => i.InstructionOpcode is LLVMOpcode.LLVMAlloca);
		}
	}

	public TypeSignature GetTypeSignature(LLVMTypeRef type)
	{
		switch (type.Kind)
		{
			case LLVMTypeKind.LLVMVoidTypeKind:
				return Definition.CorLibTypeFactory.Void;

			case LLVMTypeKind.LLVMHalfTypeKind:
				return Definition.DefaultImporter.ImportTypeSignature(typeof(Half));

			case LLVMTypeKind.LLVMFloatTypeKind:
				return Definition.CorLibTypeFactory.Single;

			case LLVMTypeKind.LLVMDoubleTypeKind:
				return Definition.CorLibTypeFactory.Double;

			case LLVMTypeKind.LLVMX86_FP80TypeKind:
				// x86_fp80 (80-bit long double) — approximated as double; precision loss is acceptable for translation.
				return Definition.CorLibTypeFactory.Double;

			case LLVMTypeKind.LLVMFP128TypeKind:
				// fp128 — approximated as double; no 128-bit float in .NET yet.
				// Todo: Use decimal?
				return Definition.CorLibTypeFactory.Double;

			case LLVMTypeKind.LLVMPPC_FP128TypeKind:
				//ppc_fp128 can be approximated by fp128, which conforms to IEEE 754 standards.
				goto case LLVMTypeKind.LLVMFP128TypeKind;

			case LLVMTypeKind.LLVMLabelTypeKind:
				goto default;

			case LLVMTypeKind.LLVMIntegerTypeKind:
				return type.IntWidth switch
				{
					//Note: non-powers of 2 are valid and might be used for bitfields.
					1 => Definition.CorLibTypeFactory.Boolean,
					8 => Definition.CorLibTypeFactory.SByte,
					16 => Definition.CorLibTypeFactory.Int16,
					32 => Definition.CorLibTypeFactory.Int32,
					64 => Definition.CorLibTypeFactory.Int64,
					128 => Definition.DefaultImporter.ImportTypeSignature(typeof(Int128)),
					// Non-standard widths (e.g. i24, i40, i48 from bitfields/packed structs):
					// round up to the next byte boundary and represent as a byte inline-array.
					uint w => GetOrCreateInlineArray(
						Definition.CorLibTypeFactory.Byte,
						(int)((w + 7) / 8)
					)
						.Type.ToTypeSignature(),
				};

			case LLVMTypeKind.LLVMFunctionTypeKind:
				//Function pointers are represented as void*, except at call sites.
				return Definition.CorLibTypeFactory.Void.MakePointerType();

			case LLVMTypeKind.LLVMStructTypeKind:
			{
				if (!structsCache.TryGetValue(type, out StructContext? structContext))
				{
					structContext = StructContext.Create(this, type);
					structsCache.Add(type, structContext);
					Structs.Add(structContext.Definition, structContext);
				}
				return structContext.Definition.ToTypeSignature();
			}

			case LLVMTypeKind.LLVMArrayTypeKind:
			{
				TypeSignature elementType = GetTypeSignature(type.ElementType);
				int count = (int)type.ArrayLength;
				TypeDefinition arrayType = GetOrCreateInlineArray(elementType, count).Type;
				return arrayType.ToTypeSignature();
			}

			case LLVMTypeKind.LLVMPointerTypeKind:
				//All pointers are opaque in IR
				return Definition.CorLibTypeFactory.Void.MakePointerType();

			case LLVMTypeKind.LLVMVectorTypeKind:
			case LLVMTypeKind.LLVMScalableVectorTypeKind:
				unsafe
				{
					// Since we control the target platform, we can set vscale to 1.

					// https://github.com/dotnet/LLVMSharp/pull/235
					//TypeSignature elementType = GetTypeSignature(type.ElementType);
					//int count = (int)type.VectorSize;
					TypeSignature elementType = GetTypeSignature(LLVM.GetElementType(type));
					int count = (int)LLVM.GetVectorSize(type);
					TypeDefinition arrayType = GetOrCreateInlineArray(elementType, count).Type;
					return arrayType.ToTypeSignature();
				}

			case LLVMTypeKind.LLVMMetadataTypeKind:
				//Metadata is not a real type, so we just use Object. Anywhere metadata is supposed to be loaded, we instead load a null value.
				return Definition.CorLibTypeFactory.Object;

			case LLVMTypeKind.LLVMTokenTypeKind:
				return Definition.CorLibTypeFactory.Void;

			case LLVMTypeKind.LLVMBFloatTypeKind:
				//Half is just an approximation of BFloat16, which is not yet supported in .NET
				//Maybe we can use this instead: https://www.nuget.org/packages/UltimateOrb.TruncatedFloatingPoints
				return Definition.DefaultImporter.ImportTypeSignature(typeof(Half));

			case LLVMTypeKind.LLVMX86_AMXTypeKind:
				goto default;

			case LLVMTypeKind.LLVMTargetExtTypeKind:
				goto default;

			default:
				throw new NotImplementedException(type.Kind.ToString());
		}
	}

	public unsafe TypeSignature GetTypeSignature(LLVMValueRef value)
	{
		LLVMOpcode opcode = value.GetOpcode();
		return value.Kind switch
		{
			LLVMValueKind.LLVMInstructionValueKind or LLVMValueKind.LLVMConstantExprValueKind =>
				opcode switch
				{
					LLVMOpcode.LLVMAlloca => GetTypeSignature(LLVM.GetAllocatedType(value))
						.MakePointerType(),
					LLVMOpcode.LLVMCatchSwitch
						or LLVMOpcode.LLVMCatchPad
						or LLVMOpcode.LLVMCleanupPad
						or LLVMOpcode.LLVMCatchRet
						or LLVMOpcode.LLVMCleanupRet => throw new NotSupportedException(
							$"Windows/MSVC EH opcode '{opcode}' is not supported on Linux x64."
						),
					LLVMOpcode.LLVMGetElementPtr => GetGEPFinalType(value).MakePointerType(),
					LLVMOpcode.LLVMRet => Definition.CorLibTypeFactory.Void,
					LLVMOpcode.LLVMStore => Definition.CorLibTypeFactory.Void,
					_ => GetTypeSignature(value.TypeOf),
				},
			LLVMValueKind.LLVMArgumentValueKind => Methods[value.ParamParent]
				.ParameterLookup[value]
				.Definition
				.ParameterType,
			LLVMValueKind.LLVMGlobalVariableValueKind => GlobalVariables[value].PointerType,
			_ => GetTypeSignature(value.TypeOf),
		};
	}

	private unsafe TypeSignature GetGEPFinalType(LLVMValueRef instruction)
	{
		Debug.Assert(instruction.GetOpcode() is LLVMOpcode.LLVMGetElementPtr);

		ReadOnlySpan<LLVMValueRef> otherIndices = instruction.GetOperands().AsSpan(2);

		LLVMTypeRef sourceElementType = LLVM.GetGEPSourceElementType(instruction);
		TypeSignature sourceElementTypeSignature = GetTypeSignature(sourceElementType);

		TypeSignature currentType = sourceElementTypeSignature;
		foreach (LLVMValueRef operand in otherIndices)
		{
			LLVMTypeRef operandType = operand.TypeOf;

			operandType.ThrowIfNotCoreLibInteger();

			TypeDefOrRefSignature structTypeSignature = (TypeDefOrRefSignature)currentType;
			TypeDefinition structType = (TypeDefinition)structTypeSignature.ToTypeDefOrRef();

			if (InlineArrayTypes.TryGetValue(structType, out InlineArrayContext? inlineArray))
			{
				currentType = inlineArray.ElementType;
			}
			else
			{
				Debug.Assert(operand.Kind == LLVMValueKind.LLVMConstantIntValueKind);

				int index = (int)operand.ConstIntSExt;
				FieldDefinition field = structType.GetInstanceField(index);
				currentType = field.Signature!.FieldType;
			}
		}

		return currentType;
	}

	private TypeDefinition CreateStaticType(string name, bool @public)
	{
		TypeDefinition typeDefinition = new(
			Options.GetNamespace(@public ? null : "Implementations"),
			name,
			(@public ? TypeAttributes.Public : TypeAttributes.NotPublic)
				| TypeAttributes.Abstract
				| TypeAttributes.Sealed,
			Definition.CorLibTypeFactory.Object.ToTypeDefOrRef()
		);
		Definition.TopLevelTypes.Add(typeDefinition);
		return typeDefinition;
	}

	private void AddCompilerGeneratedAttribute(IHasCustomAttribute hasCustomAttribute)
	{
		CustomAttributeSignature attributeSignature = new();
		CustomAttribute attribute = new(
			(ICustomAttributeType)CompilerGeneratedAttributeConstructor,
			attributeSignature
		);
		hasCustomAttribute.CustomAttributes.Add(attribute);
	}

	/// <summary>
	/// Adds a byte array field to the PrivateImplementationDetails class.
	/// </summary>
	/// <param name="fieldName">The name of the field.</param>
	/// <param name="data">The data contained within the field.</param>
	/// <returns>The field's <see cref="FieldDefinition"/>.</returns>
	public FieldDefinition AddStoredDataField(ReadOnlySpan<byte> data)
	{
		TypeDefinition nestedType = GetOrCreateStaticArrayInitType(data.Length);

		string fieldName = HashDataToBase64(data);
		TypeSignature fieldType = nestedType.ToTypeSignature();

		if (
			storedDataFieldCache.TryGetValue(
				fieldName,
				out FieldDefinition? privateImplementationField
			)
		)
		{
			Debug.Assert(
				SignatureComparer.Default.Equals(
					privateImplementationField.Signature?.FieldType,
					fieldType
				)
			);
		}
		else
		{
			privateImplementationField = new FieldDefinition(
				fieldName,
				FieldAttributes.Assembly | FieldAttributes.Static,
				fieldType
			);
			privateImplementationField.IsInitOnly = true;
			privateImplementationField.FieldRva = new DataSegment(data.ToArray());
			privateImplementationField.HasFieldRva = true;
			AddCompilerGeneratedAttribute(privateImplementationField);

			PrivateImplementationDetails.Fields.Add(privateImplementationField);
			storedDataFieldCache.Add(fieldName, privateImplementationField);
		}

		return privateImplementationField;

		//This might not be the correct way to choose a field name, but I think the specification allows it.
		//In any case, ILSpy handles it the way we want, which is all that matters.
		static string HashDataToBase64(ReadOnlySpan<byte> data)
		{
			byte[] hash = SHA256.HashData(data);
			return Convert.ToBase64String(hash, Base64FormattingOptions.None);
		}
	}

	private TypeDefinition GetOrCreateStaticArrayInitType(int length)
	{
		string name = $"__StaticArrayInitTypeSize={length}";

		foreach (TypeDefinition nestedType in PrivateImplementationDetails.NestedTypes)
		{
			if (nestedType.Name == name)
			{
				return nestedType;
			}
		}

		TypeDefinition result = new TypeDefinition(
			null,
			name,
			TypeAttributes.NestedPrivate
				| TypeAttributes.ExplicitLayout
				| TypeAttributes.AnsiClass
				| TypeAttributes.Sealed
		);
		PrivateImplementationDetails.NestedTypes.Add(result);

		result.BaseType = Definition.DefaultImporter.ImportType(typeof(ValueType));
		result.ClassLayout = new ClassLayout(1, (uint)length);
		AddCompilerGeneratedAttribute(result);

		return result;
	}
}
