using System.Text.RegularExpressions;
using AsmResolver.DotNet;
using AsmResolver.DotNet.Signatures;
using AsmResolver.PE.DotNet.Metadata.Tables;
using AssetRipper.Translation.LlvmIR.Extensions;
using LLVMSharp.Interop;

namespace AssetRipper.Translation.LlvmIR;

internal sealed partial class StructContext : IHasName
{
	/// <inheritdoc/>
	public string MangledName => Type.StructName;

	/// <inheritdoc/>
	public string? DemangledName { get; }

	/// <inheritdoc/>
	public string CleanName { get; }

	/// <inheritdoc/>
	public string Name
	{
		get => Definition.Name ?? "";
		set => Definition.Name = value;
	}

	string? IHasName.NativeType => null;

	public ModuleContext Module { get; }

	public TypeDefinition Definition { get; }

	public LLVMTypeRef Type { get; }

	private StructContext(ModuleContext module, TypeDefinition definition, LLVMTypeRef type)
	{
		Module = module;
		Definition = definition;
		Type = type;
		DemangledName = ExtractDemangledName(MangledName);
		CleanName = ExtractCleanName(MangledName, DemangledName, module.Options);
	}

	public static unsafe StructContext Create(ModuleContext module, LLVMTypeRef type)
	{
		TypeDefinition typeDefinition = new(
			module.Options.GetNamespace("Structures"),
			$"{type.StructName}_{Guid.NewGuid()}",
			TypeAttributes.Public | TypeAttributes.ExplicitLayout,
			module.Definition.DefaultImporter.ImportType(typeof(ValueType))
		);
		module.Definition.TopLevelTypes.Add(typeDefinition);
		StructContext structContext = new(module, typeDefinition, type);

		LLVMTargetDataRef targetData = LLVM.GetModuleDataLayout(module.Module);
		ulong size = targetData.ABISizeOfType(type);

		LLVMTypeRef[] array = type.GetSubtypes();
		for (int i = 0; i < array.Length; i++)
		{
			ulong offset = targetData.OffsetOfElement(type, (uint)i);

			LLVMTypeRef subType = array[i];
			TypeSignature fieldType = module.GetTypeSignature(subType);
			string fieldName = $"field_{i}";
			FieldDefinition field = new(fieldName, FieldAttributes.Public, fieldType);
			field.FieldOffset = (int)offset;
			typeDefinition.Fields.Add(field);
		}

		typeDefinition.ClassLayout = new ClassLayout(0, (uint)size);

		return structContext;
	}

	public void AddNameAttributes() => this.AddNameAttributes(Definition);

	private static string ExtractCleanName(
		string mangledName,
		string demangledName,
		TranslatorOptions options
	)
	{
		if (options.RenamedSymbols.TryGetValue(mangledName, out string? result))
		{
			if (!NameGenerator.IsValidCSharpName(result))
			{
				throw new ArgumentException(
					$"Renamed symbol '{mangledName}' has an invalid name '{result}'.",
					nameof(options)
				);
			}
			return result;
		}
		else
		{
			return options.StripNamePrefix(NameGenerator.CleanName(demangledName, "Struct"));
		}
	}

	private static string ExtractDemangledName(string name)
	{
		name = name.RemovePrefix("class.").RemovePrefix("struct.").RemovePrefix("union.");

		// Strip all trailing .N suffixes (LLVM type disambiguation tags like .5127, .16, etc.).
		// Some names carry two layers (e.g. BigInt.16.467 → BigInt.16 → BigInt), so we loop.
		while (true)
		{
			Match match = NumericalSuffix.Match(name);
			if (match.Success)
			{
				name = match.Groups[1].Value;
			}
			else
			{
				break;
			}
		}

		// Strip the ".base" suffix that LLVM adds to the primary base-dispatch object of
		// C++ classes with virtual tables (e.g. "WriteBuffer.base" → "WriteBuffer").
		name = name.RemoveSuffix(".base");

		return name;
	}

	public override string ToString()
	{
		return CleanName;
	}

	[GeneratedRegex(@"^(.*)\.\d+$")]
	private static partial Regex NumericalSuffix { get; }
}
