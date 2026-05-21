using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using AsmResolver.DotNet;
using AsmResolver.DotNet.Code.Cil;
using AsmResolver.DotNet.Collections;
using AsmResolver.DotNet.Signatures;
using AsmResolver.PE.DotNet.Cil;
using AsmResolver.PE.DotNet.Metadata.Tables;
using AssetRipper.CIL;
using AssetRipper.Translation.LlvmIR.Extensions;
using AssetRipper.Translation.LlvmIR.Runtime;
using LLVMSharp.Interop;

namespace AssetRipper.Translation.LlvmIR;

[DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
internal sealed class FunctionContext : IHasName
{
	private FunctionContext(
		LLVMValueRef function,
		MethodDefinition definition,
		ModuleContext module
	)
	{
		Function = function;
		Definition = definition;
		Module = module;

		MangledName = Function.Name;
		DemangledName = function.DemangledName;

		Debug.Assert(definition.Signature is not null);
		definition.Signature.ReturnType = ReturnTypeSignature;

		LLVMValueRef[] normalParameterRefs = function.GetParams();
		NormalParameters = new ParameterContext[normalParameterRefs.Length];
		for (int i = 0; i < normalParameterRefs.Length; i++)
		{
			LLVMValueRef parameter = normalParameterRefs[i];
			ParameterContext parameterContext = new(
				parameter,
				definition.AddParameter(module.Definition.CorLibTypeFactory.Object),
				this
			);
			NormalParameters[i] = parameterContext;
			ParameterLookup[parameter] = parameterContext;
		}

		if (IsVariadic)
		{
			VariadicParameter = new(
				definition.AddParameter(module.Definition.CorLibTypeFactory.Object),
				this
			);
		}

		if (
			module.Options.ParseDemangledSymbols
			&& !string.IsNullOrEmpty(DemangledName)
			&& DemangledName != MangledName
			&& DemangledNamesParser.ParseFunction(
				DemangledName,
				out string? returnType,
				out _,
				out string? typeName,
				out string? functionIdentifier,
				out string? functionName,
				out _,
				out string[]? parameterTypes
			)
		)
		{
			NativeType = returnType;

			if (ParameterCount == parameterTypes.Length)
			{
				int i = 0;
				foreach (BaseParameterContext parameter in AllParameters)
				{
					parameter.NativeType = parameterTypes[i];
					i++;
				}
			}
			else if (!string.IsNullOrEmpty(typeName) && ParameterCount - 1 == parameterTypes.Length)
			{
				int i = 0;
				foreach (BaseParameterContext parameter in AllParameters.Skip(1))
				{
					parameter.NativeType = parameterTypes[i];
					i++;
				}
			}
		}
		else
		{
			returnType = null;
			typeName = null;
			functionIdentifier = null;
			functionName = null;
		}

		// Apply parameter names from DISubprogram retained nodes when the LLVM IR
		// parameter names have been stripped by optimisation (e.g. -O2 / LTO builds).
		// Clang emits parameters in argument order first inside retainedNodes, so the
		// i-th DILocalVariable maps to the i-th user-visible parameter.
		ApplyDebugParameterNames();

		AllParameters.AssignNames();
		foreach (BaseParameterContext parameter in AllParameters)
		{
			ParameterDefinition parameterDefinition = parameter.Definition.GetOrCreateDefinition();
			parameterDefinition.Name = parameter.Name;
			parameter.AddNameAndTypeAttributes(parameterDefinition);
		}

		if (module.Options.RenamedSymbols.TryGetValue(MangledName, out string? result))
		{
			if (!NameGenerator.IsValidCSharpName(result))
			{
				throw new ArgumentException(
					$"Renamed symbol '{MangledName}' has an invalid name '{result}'.",
					nameof(module)
				);
			}
		}
		else if (string.IsNullOrEmpty(functionIdentifier))
		{
			// When the demangled name is available but the parser didn't recognize it as a
			// standard function signature (e.g. anonymous-namespace symbols, template statics,
			// or local-function suffixes like "(.1311)"), derive the class name from the
			// demangled name instead of from the raw mangled name.  NameGenerator.CleanName
			// replaces every non-word character (::, <>, (), spaces, dots…) with '_' and
			// collapses runs, so the result is always a valid C# identifier.
			if (!string.IsNullOrEmpty(DemangledName) && DemangledName != MangledName)
			{
				result = NameGenerator.CleanName(DemangledName, "Function");
			}
			else
			{
				result = NameGenerator.CleanName(TryGetSimpleName(MangledName), "Function");
			}
		}
		else if (
			string.IsNullOrEmpty(returnType)
			&& !string.IsNullOrEmpty(typeName)
			&& (
				functionName == typeName
				// Catch constructors of templated types where the template args appear on the
				// declaring type but not on the function name itself.
				// e.g. FPBits<float>::FPBits(float): functionName="FPBits", typeName="FPBits<float>".
				|| (
					functionName == functionIdentifier
					&& typeName.StartsWith(functionIdentifier + "<", StringComparison.Ordinal)
				)
			)
		)
		{
			result = NameGenerator.CleanName(typeName, "Type") + "_Constructor";
		}
		else if (
			string.IsNullOrEmpty(returnType)
			&& (
				functionName == $"~{typeName}"
				// Catch destructors of templated types where typeName includes template args.
				// e.g. ~FPBits for FPBits<float>: functionIdentifier="~FPBits", typeName="FPBits<float>".
				|| (
					!string.IsNullOrEmpty(typeName)
					&& functionIdentifier.StartsWith("~", StringComparison.Ordinal)
					&& typeName.StartsWith(functionIdentifier[1..], StringComparison.Ordinal)
				)
			)
		)
		{
			result = NameGenerator.CleanName(typeName ?? "", "Type") + "_Destructor";
		}
		else if (returnType is "void *" && functionName == "`scalar deleting dtor'")
		{
			result = NameGenerator.CleanName(typeName ?? "", "Type") + "_Delete";
		}
		else if (functionIdentifier.StartsWith("operator", StringComparison.Ordinal))
		{
			string operatatorName = functionIdentifier switch
			{
				"operator==" => "Equals",
				"operator!=" => "NotEquals",
				"operator<" => "LessThan",
				"operator>" => "GreaterThan",
				"operator<=" => "LessThanOrEquals",
				"operator>=" => "GreaterThanOrEquals",
				"operator+" => "Add",
				"operator-" => "Subtract",
				"operator*" => "Multiply",
				"operator/" => "Divide",
				"operator%" => "Modulo",
				"operator&" => "BitwiseAnd",
				"operator|" => "BitwiseOr",
				"operator^" => "BitwiseXor",
				"operator~" => "BitwiseNot",
				"operator<<" => "LeftShift",
				"operator>>" => "RightShift",
				"operator->" => "PointerDereference",
				"operator++" => "Increment",
				"operator--" => "Decrement",
				"operator=" => "Assignment",
				"operator[]" => "Index",
				"operator()" => "Invoke",
				"operator bool" => "ToBoolean",
				"operator short" => "ToInt16",
				"operator int" => "ToInt32",
				"operator long long" => "ToInt64",
				"operator unsigned short" => "ToUInt16",
				"operator unsigned int" => "ToUInt32",
				"operator unsigned long long" => "ToUInt64",
				"operator float" => "ToSingle",
				"operator double" => "ToDouble",
				"operator new" => "New",
				"operator delete" => "Delete",
				"operator new[]" => "NewArray",
				"operator delete[]" => "DeleteArray",
				_ => NameGenerator.CleanName(functionIdentifier["operator".Length..], "Operator"),
			};
			if (string.IsNullOrEmpty(typeName))
			{
				result = operatatorName;
			}
			else
			{
				string cleanTypeName = NameGenerator.CleanName(typeName ?? "", "Type");
				result = $"{cleanTypeName}_{operatatorName}";
			}
		}
		else
		{
			// For member functions, include the innermost type name so that template
			// specialisations become distinguishable without a random hash.
			// e.g. Endian<1234u>::to_big_endian<unsigned long>
			//      → "Endian_1234u_to_big_endian_unsigned_long"
			// For free functions use the full function name (including template args).
			// e.g. multiply_add<double> → "multiply_add_double"
			if (!string.IsNullOrEmpty(typeName))
			{
				result = NameGenerator.CleanName($"{typeName}_{functionName}", "Function");
			}
			else
			{
				result = NameGenerator.CleanName(functionName, "Function");
			}
		}

		CleanName = module.Options.StripNamePrefix(result).CapitalizeGetOrSet();
	}

	public static FunctionContext Create(LLVMValueRef function, ModuleContext module)
	{
		TypeDefinition declaringType = new(
			module.Options.GetNamespace("GlobalFunctions"),
			null,
			TypeAttributes.NotPublic
				| TypeAttributes.Class
				| TypeAttributes.Abstract
				| TypeAttributes.Sealed
				| TypeAttributes.BeforeFieldInit,
			module.Definition.CorLibTypeFactory.Object.ToTypeDefOrRef()
		);
		module.Definition.TopLevelTypes.Add(declaringType);

		MethodSignature signature = MethodSignature.CreateStatic(null!);
		MethodDefinition definition = new(
			"Invoke",
			MethodAttributes.Public | MethodAttributes.Static | MethodAttributes.HideBySig,
			signature
		);
		definition.CilMethodBody = new();
		declaringType.Methods.Add(definition);

		FunctionContext context = new(function, definition, module);
		module.Methods.Add(function, context);

		// Pointer
		{
			TypeSignature voidPointerType =
				module.Definition.CorLibTypeFactory.Void.MakePointerType();

			FieldDefinition pointerField = new(
				"__pointer",
				FieldAttributes.Public | FieldAttributes.Static | FieldAttributes.InitOnly,
				voidPointerType
			);
			declaringType.Fields.Add(pointerField);

			context.PointerField = pointerField;
		}

		return context;
	}

	/// <inheritdoc/>
	public string MangledName { get; }

	/// <summary>
	/// The demangled name of the function, which might have signature information.
	/// </summary>
	public string? DemangledName { get; }

	/// <inheritdoc/>
	public string CleanName { get; }

	/// <inheritdoc/>
	public string Name { get; set; } = "";

	/// <inheritdoc/>
	public string? NativeType { get; set; }
	public bool MightThrowAnException { get; set; }
	public LLVMValueRef Function { get; }
	public unsafe bool IsVariadic => LLVM.IsFunctionVarArg(FunctionType) != 0;
	public LLVMTypeRef FunctionType => Function.FunctionType;
	public LLVMTypeRef ReturnType => Function.ReturnType;
	public TypeSignature ReturnTypeSignature => Module.GetTypeSignature(ReturnType);
	public bool IsVoidReturn => ReturnType.Kind == LLVMTypeKind.LLVMVoidTypeKind;
	public FunctionContext? PersonalityFunction =>
		Function.HasPersonalityFn ? Module.Methods.TryGetValue(Function.PersonalityFn) : null;
	public bool IsIntrinsic => Function.BasicBlocksCount == 0;
	public ParameterContext[] NormalParameters { get; private set; } = [];
	public VariadicParameterContext? VariadicParameter { get; private set; }
	public IEnumerable<BaseParameterContext> AllParameters =>
		VariadicParameter is null
			? NormalParameters
			: NormalParameters.Append<BaseParameterContext>(VariadicParameter);
	public int ParameterCount => NormalParameters.Length + (VariadicParameter is not null ? 1 : 0);
	public AttributeWrapper[] Attributes =>
		AttributeWrapper.FromArray(
			Function.GetAttributesAtIndex(LLVMAttributeIndex.LLVMAttributeFunctionIndex)
		);
	public AttributeWrapper[] ReturnAttributes =>
		AttributeWrapper.FromArray(
			Function.GetAttributesAtIndex(LLVMAttributeIndex.LLVMAttributeReturnIndex)
		);
	public MethodDefinition Definition { get; }
	public TypeDefinition DeclaringType => Definition.DeclaringType!;
	public ModuleContext Module { get; }
	public Dictionary<LLVMValueRef, ParameterContext> ParameterLookup { get; } = new();
	public bool NeedsStackFrame { get; set; }
	public TypeDefinition? LocalVariablesType { get; set; }
	public CilLocalVariable? StackFrameVariable { get; set; }
	public CilLocalVariable? LocalVariablesPointer { get; set; }
	internal FieldDefinition PointerField { get; set; } = null!;
	private bool IsPointerFieldUsed { get; set; } = false;

	/// <summary>
	/// The public wrapper method emitted into <c>GlobalMembers</c> by
	/// <see cref="AddPublicImplementation"/>. Set after that method has been called.
	/// Used by <see cref="ApplyDwarfParameterTypes"/> to keep the public signature
	/// in sync when DWARF types are applied after the wrapper has been generated.
	/// </summary>
	public MethodDefinition? PublicMethod { get; private set; }

	public BaseParameterContext GetParameter(int index)
	{
		ArgumentOutOfRangeException.ThrowIfNegative(index);
		if (index < NormalParameters.Length)
		{
			return NormalParameters[index];
		}
		else if (index == NormalParameters.Length && VariadicParameter is not null)
		{
			return VariadicParameter;
		}
		else
		{
			throw new IndexOutOfRangeException();
		}
	}

	public void AddLocalVariablesPointer(CilInstructionCollection instructions)
	{
		Debug.Assert(LocalVariablesPointer is not null);
		instructions.Add(CilOpCodes.Ldloc, LocalVariablesPointer);
	}

	public void AddLoadFunctionPointer(CilInstructionCollection instructions)
	{
		IsPointerFieldUsed = true;
		instructions.Add(CilOpCodes.Ldsfld, PointerField);
	}

	public void RemovePointerFieldIfNotUsed()
	{
		if (!IsPointerFieldUsed)
		{
			DeclaringType.Fields.Remove(PointerField);
			PointerField = null!;
		}
		else
		{
			MethodDefinition staticConstructor = DeclaringType.GetOrCreateStaticConstructor();
			CilInstructionCollection instructions = staticConstructor.CilMethodBody!.Instructions;

			// When multiple functions share a merged declaring type, each adds its own
			// __pointer field initialisation.  Remove any trailing Ret left by a previous
			// call so we can append this field's init block, then re-add a single Ret.
			if (instructions.Count > 0 && instructions[^1].OpCode == CilOpCodes.Ret)
			{
				instructions.RemoveAt(instructions.Count - 1);
			}

			instructions.Add(CilOpCodes.Ldftn, Definition);
			instructions.Add(
				CilOpCodes.Call,
				Module.ImportRuntimeMethod(
					Module
						.InjectedTypes[typeof(PointerIndices)]
						.GetMethodByName(nameof(PointerIndices.Register))
				)
			);
			instructions.Add(CilOpCodes.Stsfld, PointerField);
			instructions.Add(CilOpCodes.Ret);
		}
	}

	public void AddPublicImplementation()
	{
		MethodDefinition method = Definition;
		Debug.Assert(method.Signature is not null);

		MethodDefinition newMethod;
		CilInstructionCollection instructions;
		CilLocalVariable? returnLocal;
		if (TryGetStructReturnType(out TypeSignature? returnTypeSignature))
		{
			newMethod = new(
				Name,
				method.Attributes,
				MethodSignature.CreateStatic(
					returnTypeSignature,
					method.Signature.ParameterTypes.Skip(1)
				)
			);
			Module.GlobalMembersType.Methods.Add(newMethod);
			PublicMethod = newMethod;
			newMethod.CilMethodBody = new();

			instructions = newMethod.CilMethodBody.Instructions;
			returnLocal = instructions.AddLocalVariable(returnTypeSignature);
			instructions.InitializeDefaultValue(returnLocal);
			instructions.Add(CilOpCodes.Ldloca, returnLocal);
			foreach (Parameter parameter in newMethod.Parameters)
			{
				instructions.Add(CilOpCodes.Ldarg, parameter);
			}
			instructions.Add(CilOpCodes.Call, method);

			// Copy parameter names from the original method to the new method.
			for (int i = 0; i < newMethod.Parameters.Count; i++)
			{
				Parameter originalParameter = method.Parameters[i + 1];
				Parameter newParameter = newMethod.Parameters[i];
				Debug.Assert(originalParameter.Definition is not null);
				ParameterDefinition newParameterDefinition = newParameter.GetOrCreateDefinition();
				newParameterDefinition.Name = originalParameter.Definition.Name;
				GetParameter(i + 1).AddNameAndTypeAttributes(newParameterDefinition);
			}
		}
		else
		{
			newMethod = new(
				Name,
				method.Attributes,
				MethodSignature.CreateStatic(
					method.Signature.ReturnType,
					method.Signature.ParameterTypes
				)
			);
			Module.GlobalMembersType.Methods.Add(newMethod);
			PublicMethod = newMethod;
			newMethod.CilMethodBody = new();

			instructions = newMethod.CilMethodBody.Instructions;

			foreach (Parameter parameter in newMethod.Parameters)
			{
				instructions.Add(CilOpCodes.Ldarg, parameter);
			}
			instructions.Add(CilOpCodes.Call, method);

			// Copy parameter names from the original method to the new method.
			for (int i = 0; i < newMethod.Parameters.Count; i++)
			{
				Parameter originalParameter = method.Parameters[i];
				Parameter newParameter = newMethod.Parameters[i];
				Debug.Assert(originalParameter.Definition is not null);
				ParameterDefinition newParameterDefinition = newParameter.GetOrCreateDefinition();
				newParameterDefinition.Name = originalParameter.Definition.Name;
				GetParameter(i).AddNameAndTypeAttributes(newParameterDefinition);
			}

			if (IsVoidReturn)
			{
				returnLocal = null;
			}
			else
			{
				returnLocal = instructions.AddLocalVariable(method.Signature.ReturnType);
				instructions.Add(CilOpCodes.Stloc, returnLocal);
			}
		}

		if (MightThrowAnException)
		{
			MethodDefinition exitToUserCode = Module
				.InjectedTypes[typeof(StackFrameList)]
				.GetMethodByName(nameof(StackFrameList.ExitToUserCode));
			IMethodDefOrRef exitToUserCodeImported = Module.ImportRuntimeMethod(exitToUserCode);

			CilInstructionLabel returnLabel = new();

			ICilLabel tryStartLabel = instructions[0].CreateLabel();
			ICilLabel tryEndLabel = instructions.Add(CilOpCodes.Leave, returnLabel).CreateLabel();

			ICilLabel handlerStartLabel = instructions.Add(CilOpCodes.Pop).CreateLabel();
			instructions.Add(CilOpCodes.Call, exitToUserCodeImported); // Clean up the stack frame.
			ICilLabel handlerEndLabel = instructions.Add(CilOpCodes.Rethrow).CreateLabel(); // Continue propagating the exception.

			returnLabel.Instruction = instructions.Add(CilOpCodes.Call, exitToUserCodeImported); // Clean up the stack frame and maybe throw an exception.

			CilExceptionHandler exceptionHandler = new()
			{
				HandlerType = CilExceptionHandlerType.Exception,
				TryStart = tryStartLabel,
				TryEnd = tryEndLabel,
				HandlerStart = handlerStartLabel,
				HandlerEnd = handlerEndLabel,
				ExceptionType = Module.Definition.CorLibTypeFactory.Object.ToTypeDefOrRef(),
			};
			instructions.Owner.ExceptionHandlers.Add(exceptionHandler);
		}

		if (returnLocal is not null)
		{
			instructions.Add(CilOpCodes.Ldloc, returnLocal);
		}
		instructions.Add(CilOpCodes.Ret);
		instructions.OptimizeMacros();

		this.AddNameAndTypeAttributes(newMethod);

		bool TryGetStructReturnType([NotNullWhen(true)] out TypeSignature? type)
		{
			if (IsVoidReturn && NormalParameters.Length > 0)
			{
				type = NormalParameters[0].StructReturnTypeSignature;
				return type is not null;
			}

			type = default;
			return false;
		}
	}

	private string GetDebuggerDisplay()
	{
		return Name;
	}

	/// <summary>
	/// Walks the <see cref="LLVMMetadataRef"/> operands of the function's DISubprogram to find the
	/// <c>retainedNodes</c> MDTuple and applies the DILocalVariable names to the corresponding
	/// <see cref="NormalParameters"/> entries before <see cref="IHasNameExtensions.AssignNames{T}"/>
	/// is called.
	/// </summary>
	/// <remarks>
	/// Clang always emits formal parameters first inside <c>retainedNodes</c>, in ascending argument
	/// order, followed by local variables.  Because the <c>DILocalVariable::getArg()</c> accessor is
	/// not exposed by the current binding, we use position as a proxy: the first <em>N</em>
	/// DILocalVariable nodes (where <em>N</em> is the number of user-visible parameters) are
	/// treated as parameters.
	/// </remarks>
	private void ApplyDebugParameterNames()
	{
		LLVMMetadataRef subprogram = Function.Subprogram;
		if (subprogram.Handle == IntPtr.Zero || subprogram.IsADISubprogram == default)
		{
			return;
		}

		LLVMMetadataRef retainedNodes = FindRetainedNodes(subprogram);
		if (retainedNodes.Handle == IntPtr.Zero)
		{
			return;
		}

		// Index 0 of NormalParameters is the hidden sret pointer when the function returns a
		// struct by value.  Debug info only tracks user-visible parameters, so offset by 1.
		bool hasSret =
			NormalParameters.Length > 0
			&& NormalParameters[0].StructReturnTypeSignature is not null;
		int paramOffset = hasSret ? 1 : 0;
		int userParamCount = NormalParameters.Length - paramOffset;
		int debugParamIndex = 0;

		foreach (LLVMMetadataRef node in retainedNodes.GetOperands())
		{
			if (debugParamIndex >= userParamCount)
			{
				break;
			}
			if (node.Handle == IntPtr.Zero || node.IsADILocalVariable == default)
			{
				continue;
			}
			string varName = node.Name;
			if (!string.IsNullOrEmpty(varName))
			{
				string clean = NameGenerator.CleanName(varName, "");
				if (clean.Length > 0)
				{
					NormalParameters[debugParamIndex + paramOffset].SetDebugName(clean);
				}
			}
			debugParamIndex++;
		}
	}

	/// <summary>
	/// Uses the DWARF debug types attached to each <c>DILocalVariable</c> parameter node to
	/// replace generic <c>void*</c> or integer parameter types with their true struct-pointer
	/// or enum types. Must be called after all struct and enum contexts have been created and
	/// the <paramref name="lookup"/> has been populated.
	/// Also updates <see cref="PublicMethod"/> parameter types and return type to match.
	/// </summary>
	public void ApplyDwarfParameterTypes(IReadOnlyDictionary<string, TypeSignature> lookup)
	{
		LLVMMetadataRef subprogram = Function.Subprogram;
		if (subprogram.Handle == IntPtr.Zero || subprogram.IsADISubprogram == default)
			return;

		// --- Return type ---
		// Skip sret functions — the real return type is already encoded in the sret pointer.
		bool hasSret =
			NormalParameters.Length > 0
			&& NormalParameters[0].StructReturnTypeSignature is not null;

		if (!hasSret && Definition.Signature is not null)
		{
			LLVMMetadataRef subroutineType = subprogram.Type;
			if (
				subroutineType.Handle != IntPtr.Zero
				&& subroutineType.IsADISubroutineType != default
			)
			{
				LLVMMetadataRef[] typeArray = subroutineType.GetTypeArray();
				if (typeArray.Length > 0 && typeArray[0].Handle != IntPtr.Zero)
				{
					TypeSignature? resolved = DwarfTypeResolver.TryResolve(typeArray[0], lookup);
					if (
						resolved is not null
						&& DwarfTypeResolver.IsSafeReplacement(
							Definition.Signature.ReturnType,
							resolved
						)
					)
					{
						Definition.Signature.ReturnType = resolved;
						if (PublicMethod?.Signature is not null)
							PublicMethod.Signature.ReturnType = resolved;
					}
				}
			}
		}

		// --- Parameters ---
		LLVMMetadataRef retainedNodes = FindRetainedNodes(subprogram);
		if (retainedNodes.Handle == IntPtr.Zero)
			return;

		int paramOffset = hasSret ? 1 : 0;
		int userParamCount = NormalParameters.Length - paramOffset;
		int debugParamIndex = 0;

		foreach (LLVMMetadataRef node in retainedNodes.GetOperands())
		{
			if (debugParamIndex >= userParamCount)
				break;
			if (node.Handle == IntPtr.Zero || node.IsADILocalVariable == default)
				continue;

			int implIdx = debugParamIndex + paramOffset;
			LLVMMetadataRef dwarfType = node.Type;
			if (dwarfType.Handle != IntPtr.Zero)
			{
				TypeSignature? resolved = DwarfTypeResolver.TryResolve(dwarfType, lookup);
				if (
					resolved is not null
					&& DwarfTypeResolver.IsSafeReplacement(
						NormalParameters[implIdx].TypeSignature,
						resolved
					)
				)
				{
					// Update the implementation method parameter.
					NormalParameters[implIdx].TypeSignature = resolved;

					// Update the corresponding public wrapper parameter (already created).
					if (PublicMethod?.Signature is not null)
					{
						// sret: public params start at implIdx-1 (the sret param is not exposed)
						int pubIdx = hasSret ? implIdx - 1 : implIdx;
						if (pubIdx >= 0 && pubIdx < PublicMethod.Signature.ParameterTypes.Count)
						{
							PublicMethod.Signature.ParameterTypes[pubIdx] = resolved;
						}
					}
				}
			}

			debugParamIndex++;
		}
	}

	/// <summary>
	/// Finds the <c>retainedNodes</c> MDTuple operand of a DISubprogram — the tuple that
	/// contains DILocalVariable entries for the function's parameters and locals.
	/// </summary>
	private static LLVMMetadataRef FindRetainedNodes(LLVMMetadataRef subprogram)
	{
		foreach (LLVMMetadataRef operand in subprogram.GetOperands())
		{
			if (operand.Handle == IntPtr.Zero || operand.IsAMDTuple == default)
				continue;

			foreach (LLVMMetadataRef inner in operand.GetOperands())
			{
				if (inner.Handle != IntPtr.Zero && inner.IsADILocalVariable != default)
					return operand;
			}
		}
		return default;
	}

	private static string TryGetSimpleName(string name)
	{
		if (name.StartsWith('?'))
		{
			int start = name.StartsWith("??$") ? 3 : 1;
			int end = name.IndexOf('@', start);
			return name[start..end];
		}
		else
		{
			return name;
		}
	}
}
