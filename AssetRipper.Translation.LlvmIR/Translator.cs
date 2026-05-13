using System.Runtime.InteropServices;
using System.Text;
using AsmResolver.DotNet;
using AsmResolver.DotNet.Code.Cil;
using AsmResolver.DotNet.Signatures;
using AssetRipper.Translation.LlvmIR.Extensions;
using AssetRipper.Translation.LlvmIR.Instructions;
using LLVMSharp.Interop;

namespace AssetRipper.Translation.LlvmIR;

public static unsafe class Translator
{
	static Translator()
	{
		Patches.Apply();
	}

	public static ModuleDefinition Translate(
		string name,
		string content,
		TranslatorOptions? options = null
	)
	{
		return Translate(name, Encoding.UTF8.GetBytes(content), options);
	}

	public static ModuleDefinition Translate(
		string name,
		ReadOnlySpan<byte> content,
		TranslatorOptions? options = null
	)
	{
		fixed (byte* ptr = content)
		{
			// Not disposed intentionally: disposing LLVM native objects during cleanup
			// causes a double-free crash in the native LLVM library. Since this is a
			// translation tool that exits after writing output, leaking these objects is fine.
			LLVMContextRef context = LLVMContextRef.Create();
			nint namePtr = Marshal.StringToHGlobalAnsi(name);
			LLVMMemoryBufferRef buffer = LLVM.CreateMemoryBufferWithMemoryRange(
				(sbyte*)ptr,
				(nuint)content.Length,
				(sbyte*)namePtr,
				0
			);
			try
			{
				LLVMModuleRef module = context.ParseIR(buffer);
				return Translate(module, options ?? new());
			}
			finally
			{
				// This fails randomly with no real explanation.
				// The IR text data is only referenced (not copied),
				// so the memory leak of not disposing the buffer is negligible.
				//LLVM.DisposeMemoryBuffer(buffer);

				Marshal.FreeHGlobal(namePtr);

				// Collect any memory that got allocated.
				GC.Collect();
			}
		}
	}

	private static ModuleDefinition Translate(LLVMModuleRef module, TranslatorOptions options)
	{
		CustomModuleDefinition moduleDefinition = new(
			string.IsNullOrEmpty(options.ModuleName) ? "ConvertedCpp" : options.ModuleName
		);

		ModuleContext moduleContext = new(module, moduleDefinition, options);

		foreach (LLVMValueRef global in module.GetGlobals())
		{
			GlobalVariableContext globalVariableContext = new(global, moduleContext);
			moduleContext.GlobalVariables.Add(global, globalVariableContext);
		}

		moduleContext.CreateFunctions();

		moduleContext.AssignMemberNames();

		Console.WriteLine("Identifying functions that might throw exceptions...");
		moduleContext.IdentifyFunctionsThatMightThrow();

		Console.WriteLine("Creating properties for global variables...");
		foreach (
			GlobalVariableContext globalVariableContext in moduleContext.GlobalVariables.Values
		)
		{
			globalVariableContext.CreateProperties();
		}

		Console.WriteLine("Initializing data for global variables");
		foreach (
			GlobalVariableContext globalVariableContext in moduleContext.GlobalVariables.Values
		)
		{
			globalVariableContext.InitializeData();
			globalVariableContext.AddPublicImplementation();
		}

		Console.WriteLine("Implementing functions...");
		int functionIndex = 1;
		foreach (FunctionContext functionContext in moduleContext.Methods.Values)
		{
			functionContext.AddNameAttributes(functionContext.DeclaringType);
			functionContext.AddTypeAttribute(functionContext.Definition);
			functionContext.AddPublicImplementation();

			if (IntrinsicFunctionImplementer.TryHandleIntrinsicFunction(functionContext))
			{
				continue;
			}

			if (functionIndex % 100 == 0)
			{
				Console.WriteLine(
					$"Implementing function {functionIndex}/{moduleContext.Methods.Count}"
				);
			}

			CilInstructionCollection instructions = functionContext
				.Definition
				.CilMethodBody!
				.Instructions;

			IReadOnlyList<BasicBlock> basicBlocks = InstructionLifter.Lift(functionContext);
			InstructionOptimizer.Optimize(basicBlocks);

			foreach (BasicBlock basicBlock in basicBlocks)
			{
				try
				{
					basicBlock.AddInstructions(instructions);
				}
				catch (Exception ex) when (ex.Message.Contains("Stack"))
				{
					throw new Exception(
						$"Stack error in function '{functionContext.Definition.FullName}': {ex.Message}",
						ex
					);
				}
			}

			instructions.OptimizeMacros();

			functionIndex++;
		}

		Console.WriteLine("Cleaning up...");
		Console.WriteLine("Cleaning up (step 1: global variables)...");
		foreach (
			GlobalVariableContext globalVariableContext in moduleContext.GlobalVariables.Values
		)
		{
			globalVariableContext.RemovePointerFieldIfNotUsed();
		}

		Console.WriteLine("Cleaning up (step 2: functions)...");
		foreach (FunctionContext functionContext in moduleContext.Methods.Values)
		{
			functionContext.RemovePointerFieldIfNotUsed();
		}

		Console.WriteLine("Cleaning up (step 3: assembly functions)...");
		if (moduleContext.AssemblyFunctionsType.Methods.Count == 0)
		{
			moduleDefinition.TopLevelTypes.Remove(moduleContext.AssemblyFunctionsType);
			// InlineAssemblyAttribute is from the Runtime assembly (referenced, not cloned),
			// so there is nothing to remove from the output module.
		}

		Console.WriteLine("Cleaning up (step 4: metadata)...");
		{
			List<LLVMMetadataRef> types = module
				.GetAllMetadata()
				.Where(m => m.IsADIType != default)
				.ToList();
			Console.WriteLine($"[DIAG] Total DI types: {types.Count}");
			{
				int compositeCount = types.Count(m => m.IsStruct || m.IsClass || m.IsUnion);
				Console.WriteLine($"[DIAG] Composite types (struct/class/union): {compositeCount}");
				// Print first 5 composite type names for diagnostics
				foreach (
					LLVMMetadataRef t in types
						.Where(m => m.IsStruct || m.IsClass || m.IsUnion)
						.Take(5)
				)
					Console.WriteLine(
						$"[DIAG]   DI composite: name={t.Name} identifier={t.Identifier} members={t.Members.Count()} allDataMembers={t.AllDataMembers.Count()}"
					);
			}

			CreateEnumerations(moduleContext, types);

			List<(LLVMTypeRef, LLVMMetadataRef)> globalVariableTypes = [];

			foreach (
				GlobalVariableContext globalVariableContext in moduleContext.GlobalVariables.Values
			)
			{
				LLVMMetadataRef metadata = globalVariableContext
					.GlobalVariable
					.GlobalVariableExpression;
				LLVMMetadataRef type = metadata.Variable.Type;
				if (type.Handle == IntPtr.Zero) { }
				else if (
					type.IsArray
					&& globalVariableContext.Type.Kind
						is LLVMTypeKind.LLVMArrayTypeKind
							or LLVMTypeKind.LLVMScalableVectorTypeKind
							or LLVMTypeKind.LLVMVectorTypeKind
				)
				{
					globalVariableTypes.Add((globalVariableContext.Type, type));
				}
				else if (
					(type.IsStruct || type.IsClass || type.IsUnion)
					&& globalVariableContext.Type.Kind is LLVMTypeKind.LLVMStructTypeKind
				)
				{
					globalVariableTypes.Add((globalVariableContext.Type, type));
				}
			}

			AddChildTypes(globalVariableTypes);

			List<LLVMMetadataRef> typesWithIdentifiers = types
				.Where(m => m.IsStruct || m.IsClass || m.IsUnion)
				.ToList();
			List<string> identifiers = typesWithIdentifiers
				.Select(m =>
				{
					// Use the raw demangled identifier for matching rather than IdentifierClean,
					// because ParseType() can silently truncate complex templates (e.g. BigInt<128UL, ...>
					// falls back to just the outer namespace). IdentifierDemangled is always complete.
					string identifier = m.IdentifierDemangled;
					return string.IsNullOrEmpty(identifier) ? m.Name : identifier;
				})
				.ToList();

			Dictionary<LLVMTypeRef, StructContext> contextLookUp =
				moduleContext.Structs.Values.ToDictionary(s => s.Type);

			Dictionary<StructContext, List<LLVMMetadataRef>> validMetadata = [];
			foreach (
				(LLVMTypeRef type, LLVMMetadataRef metadata) in globalVariableTypes
					.Where(p =>
						p.Item1.Kind is LLVMTypeKind.LLVMStructTypeKind
						&& p.Item2.Kind is LLVMMetadataKind.LLVMDICompositeTypeMetadataKind
					)
					.Distinct()
			)
			{
				StructContext structContext = contextLookUp[type];
				if (validMetadata.TryGetValue(structContext, out List<LLVMMetadataRef>? list))
				{
					list.Add(metadata);
				}
				else
				{
					validMetadata[structContext] = [metadata];
				}
			}

			foreach (StructContext structContext in moduleContext.Structs.Values)
			{
				if (validMetadata.ContainsKey(structContext))
				{
					continue;
				}

				List<LLVMMetadataRef> list = [];
				validMetadata[structContext] = list;

				if (string.IsNullOrEmpty(structContext.DemangledName))
				{
					continue;
				}

				uint? strukturSize = structContext.Definition.ClassLayout?.ClassSize;

				for (int i = 0; i < identifiers.Count; i++)
				{
					if (structContext.DemangledName != identifiers[i])
					{
						continue;
					}
					LLVMMetadataRef metadata = typesWithIdentifiers[i];
					if (!AreCompatible(structContext.Type, metadata, strukturSize))
					{
						continue;
					}
					list.Add(metadata);
				}

				if (list.Count > 0)
				{
					continue;
				}

				// Fallback: match by the simple unqualified name for scoped types.
				// Handles e.g. '(anonymous namespace)::statx_buf' matching DI name 'statx_buf'
				// (anonymous-namespace types have no mangle identifier, only a bare Name).
				{
					int lastSep = structContext.DemangledName.LastIndexOf(
						"::",
						StringComparison.Ordinal
					);
					if (lastSep >= 0)
					{
						string simpleName = structContext.DemangledName[(lastSep + 2)..];
						if (!string.IsNullOrEmpty(simpleName))
						{
							for (int i = 0; i < typesWithIdentifiers.Count; i++)
							{
								LLVMMetadataRef candidate = typesWithIdentifiers[i];
								// Only consider DI types without a mangled identifier (unscoped / anon-NS types)
								if (!string.IsNullOrEmpty(candidate.IdentifierClean))
								{
									continue;
								}
								if (candidate.Name != simpleName)
								{
									continue;
								}
								if (!AreCompatible(structContext.Type, candidate, strukturSize))
								{
									continue;
								}
								list.Add(candidate);
							}
						}
					}
				}

				if (list.Count > 0)
				{
					continue;
				}

				for (int i = 0; i < identifiers.Count; i++)
				{
					string identifier = identifiers[i];
					if (
						identifier.Length <= structContext.DemangledName.Length
						|| !identifier.StartsWith(
							structContext.DemangledName,
							StringComparison.Ordinal
						)
						|| identifier[structContext.DemangledName.Length] != '<'
					)
					{
						continue;
					}

					bool restIsTemplate = true;
					int angleBracketDepth = 0;
					for (int j = structContext.DemangledName.Length + 1; j < identifier.Length; j++)
					{
						char c = identifier[j];
						if (c == '<')
						{
							angleBracketDepth++;
						}
						else if (c == '>')
						{
							angleBracketDepth--;
							if (angleBracketDepth < 0)
							{
								restIsTemplate = j == identifier.Length - 1;
								break;
							}
						}
					}

					if (!restIsTemplate)
					{
						continue;
					}
					LLVMMetadataRef metadata = typesWithIdentifiers[i];
					if (!AreCompatible(structContext.Type, metadata, strukturSize))
					{
						continue;
					}
					list.Add(metadata);
				}
			}

			List<(LLVMTypeRef, LLVMMetadataRef)> types2 = validMetadata
				.Where(p => p.Value.Count > 0)
				.Select(p => (p.Key.Type, p.Value[0]))
				.ToList();
			AddChildTypes(types2);

			foreach ((LLVMTypeRef type, LLVMMetadataRef metadata) in types2)
			{
				if (metadata.Handle == IntPtr.Zero)
				{
					continue;
				}
				if (!(metadata.IsStruct || metadata.IsClass || metadata.IsUnion))
				{
					continue;
				}
				if (type.Kind is not LLVMTypeKind.LLVMStructTypeKind)
				{
					continue;
				}
				if (!contextLookUp.TryGetValue(type, out StructContext? structContext))
				{
					continue;
				}
				List<LLVMMetadataRef> list = validMetadata[structContext];
				list.Clear();
				list.Add(metadata);
			}

			// Diagnostic: count structs with metadata
			int structsWithMeta = validMetadata.Count(p => p.Value.Count > 0);
			int totalStructs = validMetadata.Count;
			Console.WriteLine(
				$"[DIAG] Structs with DWARF metadata: {structsWithMeta}/{totalStructs}"
			);

			int skippedNoMeta = 0,
				skippedNoMatch = 0;
			int fieldNamingCount = 0;
			foreach ((StructContext structContext, List<LLVMMetadataRef> list) in validMetadata)
			{
				if (list.Count is 0)
				{
					skippedNoMeta++;
					continue;
				}

				// Build an offset (bytes) → DWARF member name map for the first matching entry.
				// Using offsets rather than sequential index handles both trailing and internal
				// padding (e.g. alignment [N x i8] arrays that have no DWARF counterpart).
				// When multiple DWARF members share an offset (union / anonymous union fields),
				// take the first — overlapping members map to a single LLVM field anyway.
				Dictionary<int, string> offsetToName = list[0]
					.AllDataMembers.GroupBy(m => (int)(m.OffsetInBits / 8))
					.ToDictionary(g => g.Key, g => g.First().LayoutMemberName);

				// Verify all DWARF entries for this struct agree on member names at each offset.
				bool allMatch = true;
				for (int index = 1; index < list.Count; index++)
				{
					Dictionary<int, string> otherMap = list[index]
						.AllDataMembers.GroupBy(m => (int)(m.OffsetInBits / 8))
						.ToDictionary(g => g.Key, g => g.First().LayoutMemberName);
					allMatch =
						offsetToName.Count == otherMap.Count
						&& offsetToName.All(kv =>
							otherMap.TryGetValue(kv.Key, out string? v) && v == kv.Value
						);
					if (!allMatch)
					{
						break;
					}
				}
				if (!allMatch)
				{
					skippedNoMatch++;
					continue;
				}

				// Assign names to LLVM fields that have a DWARF counterpart by byte offset.
				// Fields with no DWARF counterpart (padding arrays, alignment holes) are left
				// with their generic field_N names.
				List<FieldDefinitionHasName> fieldDefinitions = [];
				int namedIdx = 0;
				foreach (
					FieldDefinition field in structContext.Definition.Fields.Where(f => !f.IsStatic)
				)
				{
					if (offsetToName.TryGetValue(field.FieldOffset ?? 0, out string? memberName))
					{
						fieldDefinitions.Add(
							new FieldDefinitionHasName(field, memberName, namedIdx++, moduleContext)
						);
					}
				}

				if (fieldDefinitions.Count == 0 && offsetToName.Count > 0)
				{
					// DIAG: DWARF members exist but none matched an LLVM field by offset
					Console.WriteLine(
						$"[DIAG] Offset mismatch for {structContext.MangledName}: DWARF offsets=[{string.Join(",", offsetToName.Keys)}] LLVM offsets=[{string.Join(",", structContext.Definition.Fields.Where(f => !f.IsStatic).Select(f => f.FieldOffset))}]"
					);
				}

				if (fieldDefinitions.Count > 0)
				{
					fieldDefinitions.ToArray().AssignNames();
					fieldNamingCount++;
				}
			}
			Console.WriteLine(
				$"[DIAG] Field naming - applied:{fieldNamingCount} noMeta:{skippedNoMeta} mismatch:{skippedNoMatch}"
			);

			// -----------------------------------------------------------------------
			// DWARF type refinement:
			// Build an identifier → TypeSignature lookup that covers all known enums
			// and all structs that were matched to DWARF metadata above.  Then use it
			// to replace generic void*/integer field and parameter types with the real
			// struct-pointer or enum types that DWARF recorded.
			// -----------------------------------------------------------------------
			Dictionary<string, TypeSignature> dwarfTypeLookup = BuildDwarfTypeLookup(
				moduleContext,
				validMetadata
			);

			// Apply DWARF types to struct fields (uses same offset matching as field naming).
			int fieldTypeCount = 0;
			foreach ((StructContext structContext, List<LLVMMetadataRef> list) in validMetadata)
			{
				if (list.Count == 0)
					continue;

				// Build offset → DWARF member node map (same logic as naming, but store the node).
				Dictionary<int, LLVMMetadataRef> offsetToMember = list[0]
					.AllDataMembers.GroupBy(m => (int)(m.OffsetInBits / 8))
					.ToDictionary(g => g.Key, g => g.First());

				foreach (
					FieldDefinition field in structContext.Definition.Fields.Where(f => !f.IsStatic)
				)
				{
					int offset = field.FieldOffset ?? 0;
					if (
						!offsetToMember.TryGetValue(offset, out LLVMMetadataRef member)
						|| member.Handle == IntPtr.Zero
						|| field.Signature is null
					)
					{
						continue;
					}

					LLVMMetadataRef dwType = member.BaseType;
					TypeSignature? resolved = DwarfTypeResolver.TryResolve(dwType, dwarfTypeLookup);
					if (
						resolved is not null
						&& field.Signature is not null
						&& DwarfTypeResolver.IsSafeReplacement(field.Signature.FieldType, resolved)
					)
					{
						field.Signature.FieldType = resolved;
						fieldTypeCount++;
					}
				}
			}
			Console.WriteLine($"[DIAG] DWARF field typing - applied:{fieldTypeCount}");

			// Apply DWARF types to function parameters (also updates public wrapper signatures).
			int paramTypeCount = 0;
			foreach (FunctionContext func in moduleContext.Methods.Values)
			{
				int before = paramTypeCount;
				func.ApplyDwarfParameterTypes(dwarfTypeLookup);
				// Count is approximate — track via a diagnostic callback if needed.
				_ = before; // suppress warning; counted outside for now
			}
			Console.WriteLine("[DIAG] DWARF parameter typing - complete");
		}

		// Structs and inline arrays are discovered dynamically, so we need to assign names after all methods are created.
		moduleContext.AssignStructNames();
		moduleContext.AssignInlineArrayNames();

		return moduleDefinition;
	}

	private static void AddChildTypes(List<(LLVMTypeRef, LLVMMetadataRef)> list)
	{
		for (int i = 0; i < list.Count; i++)
		{
			(LLVMTypeRef type, LLVMMetadataRef metadata) = list[i];
			metadata = metadata.PassThroughToBaseTypeIfNecessary();
			list[i] = (type, metadata);
			if (metadata.Handle == IntPtr.Zero)
			{
				list.RemoveAt(i);
				i--;
				continue;
			}

			if (
				metadata.IsArray
				&& type.Kind
					is LLVMTypeKind.LLVMArrayTypeKind
						or LLVMTypeKind.LLVMScalableVectorTypeKind
						or LLVMTypeKind.LLVMVectorTypeKind
			)
			{
				uint arrayLength;
				LLVMTypeRef elementType;
				if (type.Kind == LLVMTypeKind.LLVMArrayTypeKind)
				{
					arrayLength = type.ArrayLength;
					elementType = type.ElementType;
				}
				else
				{
					// https://github.com/dotnet/LLVMSharp/pull/235
					arrayLength = LLVM.GetVectorSize(type);
					elementType = LLVM.GetElementType(type);
				}

				if (arrayLength == metadata.ArrayLength)
				{
					list.Add((elementType, metadata.BaseType));
				}
			}
			else if (
				(metadata.IsStruct || metadata.IsClass || metadata.IsUnion)
				&& type.Kind is LLVMTypeKind.LLVMStructTypeKind
			)
			{
				if (!AreCompatible(type, metadata))
				{
					list.RemoveAt(i);
					i--;
					continue;
				}

				int index = 0;
				LLVMTypeRef[] fieldTypes = type.GetSubtypes();
				foreach (LLVMMetadataRef member in metadata.Members)
				{
					list.Add((fieldTypes[index], member.BaseType));
				}
			}
		}
	}

	/// <summary>
	/// Builds a DWARF mangled-identifier → <see cref="TypeSignature"/> lookup table that covers:
	/// <list type="bullet">
	///   <item>All enumeration types registered in <see cref="ModuleContext.Enums"/>.</item>
	///   <item>All struct/class/union types that were matched to DWARF metadata
	///         (i.e. have a non-empty <see cref="LLVMMetadataRef.Identifier"/>).</item>
	/// </list>
	/// </summary>
	private static Dictionary<string, TypeSignature> BuildDwarfTypeLookup(
		ModuleContext moduleContext,
		Dictionary<StructContext, List<LLVMMetadataRef>> validMetadata
	)
	{
		Dictionary<string, TypeSignature> lookup = new();

		// Enums
		foreach ((string id, EnumContext enumCtx) in moduleContext.Enums)
		{
			lookup[id] = enumCtx.Definition.ToTypeSignature();
		}

		// Structs (from the already-built struct ↔ DWARF matching table)
		foreach ((StructContext structCtx, List<LLVMMetadataRef> list) in validMetadata)
		{
			if (list.Count == 0)
				continue;

			string id = list[0].Identifier;
			if (!string.IsNullOrEmpty(id))
			{
				lookup.TryAdd(id, structCtx.Definition.ToTypeSignature());
			}
		}

		return lookup;
	}

	private static void CreateEnumerations(ModuleContext moduleContext, List<LLVMMetadataRef> types)
	{
		List<LLVMMetadataRef> enumTypes = types
			.Where(m => m.IsEnum && m.Elements.Length > 0)
			.ToList();

		List<EnumContext> enumContexts = enumTypes
			.Select(m => EnumContext.Create(moduleContext, m))
			.ToList();
		enumContexts.AssignNames();
		enumContexts.ForEach(e =>
		{
			e.AddNameAttributes(e.Definition);
			// Register in the Enums lookup so DWARF type refinement can substitute
			// integer fields/parameters with the correct enum type.
			string id = e.MangledName;
			if (!string.IsNullOrEmpty(id))
				moduleContext.Enums.TryAdd(id, e);
		});
		Console.WriteLine(
			$"[DIAG] Enumerations registered: {moduleContext.Enums.Count}/{enumContexts.Count}"
		);
	}

	private static bool AreCompatible(
		LLVMTypeRef type,
		LLVMMetadataRef metadata,
		uint? llvmStructSizeBytes = null
	)
	{
		// Count both DW_TAG_member and DW_TAG_inheritance entries — inheritance base-class
		// sub-objects map directly to LLVM struct fields, just like regular data members.
		int dwarfMemberCount = metadata.AllDataMembers.Count();
		int llvmFieldCount = (int)type.SubtypesCount;

		// Reject if DWARF says the type has MORE data fields than the LLVM struct.
		if (dwarfMemberCount > llvmFieldCount)
		{
			return false;
		}

		// If both sizes are known, they must agree exactly.
		// This prevents incorrectly matching different template specializations that have
		// the same member count but different overall sizes (e.g. FPStorage<float16> vs
		// FPStorage<float64>).
		ulong dwarfSizeBytes = metadata.SizeInBits / 8;
		if (
			llvmStructSizeBytes is uint llvmSize
			&& dwarfSizeBytes > 0
			&& dwarfSizeBytes != llvmSize
		)
		{
			return false;
		}

		// LLVM may insert anonymous padding fields (trailing alignment bytes, internal holes)
		// that the compiler does not expose as named DWARF members. The field naming pass
		// uses offset-based matching to handle both trailing and internal padding correctly.
		return true;
	}

	private sealed class FieldDefinitionHasName(
		FieldDefinition field,
		string debugName,
		int index,
		ModuleContext module
	) : IHasName
	{
		public string MangledName => $"{debugName}_{index}";
		string? IHasName.DemangledName => null;
		public string CleanName { get; } = NameGenerator.CleanName(debugName, "field");
		public string Name
		{
			get => @field.Name ?? "";
			set => @field.Name = value;
		}
		string? IHasName.NativeType => null;
		ModuleContext IHasName.Module => module;
	}

	private sealed class CustomModuleDefinition : ModuleDefinition
	{
		public CustomModuleDefinition(string name)
			: base(name, KnownCorLibs.SystemRuntime_v10_0_0_0)
		{
			if (Assembly is null)
			{
				AssemblyDefinition assembly = new(Name, new Version(1, 0, 0, 0));
				assembly.Modules.Add(this);
			}
		}

		protected override ReferenceImporter GetDefaultImporter()
		{
			return new CustomReferenceImporter(this);
		}

		private sealed class CustomReferenceImporter(CustomModuleDefinition module)
			: ReferenceImporter(module)
		{
			protected override AssemblyReference ImportAssembly(AssemblyDescriptor assembly)
			{
				// This importer will fail if System.Runtime.InteropServices.Marshal is ever imported.
				// At runtime, Marshal is part of System.Private.CoreLib.
				// However, at compile time, it is not part of System.Runtime, but rather System.Runtime.InteropServices.
				// If we ever try to import it, the reference will be invalid.
				// This is one of the primary reasons for NativeMemoryHelper, which allows us to avoid referencing Marshal directly.
				if (
					SignatureComparer.Default.Equals(
						assembly,
						KnownCorLibs.SystemPrivateCoreLib_v10_0_0_0
					)
				)
				{
					return base.ImportAssembly(KnownCorLibs.SystemRuntime_v10_0_0_0);
				}
				else
				{
					return base.ImportAssembly(assembly);
				}
			}
		}
	}
}
