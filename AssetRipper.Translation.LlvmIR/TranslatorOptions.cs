namespace AssetRipper.Translation.LlvmIR;

public sealed record class TranslatorOptions
{
	/// <summary>
	/// The root namespace to use for the generated assembly.
	/// </summary>
	public string? Namespace { get; set; }

	/// <summary>
	/// The module name to use for the generated assembly.
	/// </summary>
	public string? ModuleName { get; set; }

	/// <summary>
	/// The public class name to use in the generated assembly.
	/// </summary>
	public string? ClassName { get; set; }

	public Dictionary<string, string> RenamedSymbols { get; init; } = new();

	/// <summary>
	/// A list of clean-name prefixes to strip from the beginning of generated identifiers.
	/// Prefixes are matched against the already-sanitized name (word characters and underscores only).
	/// For example, to strip the versioned llvm-libc namespace prefix, add <c>"llvm_libc_22_1_4_"</c>.
	/// </summary>
	public string[] StripNamePrefixes { get; init; } = [];

	/// <summary>
	/// Strips the first matching prefix in <see cref="StripNamePrefixes"/> from <paramref name="name"/>,
	/// returning the original string if no prefix matches or if stripping would leave an empty string.
	/// Also removes all mid-name occurrences of the form <c>_prefix</c> (underscore-separated fragments).
	/// </summary>
	public string StripNamePrefix(string name)
	{
		foreach (string prefix in StripNamePrefixes)
		{
			// Strip leading occurrence: "prefix_foo" → "foo"
			if (name.Length > prefix.Length && name.StartsWith(prefix, StringComparison.Ordinal))
			{
				name = name[prefix.Length..];
			}

			// Strip mid-name occurrences: "Type_prefix_foo" → "Type_foo"
			// The separator underscore before the prefix is preserved (collapsed into the following word).
			string midToken = "_" + prefix;
			if (name.Contains(midToken, StringComparison.Ordinal))
			{
				name = name.Replace(midToken, "_", StringComparison.Ordinal);
				// Collapse any double underscores that may have been created
				while (name.Contains("__", StringComparison.Ordinal))
				{
					name = name.Replace("__", "_", StringComparison.Ordinal);
				}
				// Trim any leading/trailing underscores that remain
				name = name.Trim('_');
				if (name.Length == 0)
				{
					name = "Stripped";
				}
			}
		}
		return name;
	}

	/// <summary>
	/// If true, demangled names will be parsed in order to extract additional information.
	/// </summary>
	public bool ParseDemangledSymbols { get; set; }

	/// <summary>
	/// If true, name attributes will be included in the output.
	/// </summary>
	public bool EmitNameAttributes { get; set; }

	/// <summary>
	/// If true, constant structs and arrays will be initialized from precomputed binary data.
	/// </summary>
	public bool PrecomputeInitializers { get; set; }

	/// <summary>
	/// Previously-translated assemblies that this translation depends on.
	/// </summary>
	/// <remarks>
	/// <para>
	/// When a forward-declared (external) function cannot be resolved within the current module,
	/// the translator searches each dependency's function index (built from <c>[MangledName]</c>
	/// attributes on public methods) before falling back to a <c>NotImplementedException</c> stub.
	/// </para>
	/// <para>
	/// Dependencies must have been translated with <see cref="EmitNameAttributes"/> set to
	/// <see langword="true"/> so that <c>[MangledName]</c> attributes are present for index
	/// building.  See <see cref="TranslatedAssemblyDependency"/> for construction options
	/// (from a <c>.dll</c> path or an in-memory <see cref="AsmResolver.DotNet.ModuleDefinition"/>).
	/// </para>
	/// </remarks>
	public IReadOnlyList<TranslatedAssemblyDependency> Dependencies { get; init; } = [];

	/// <summary>
	/// Maps inline assembly (asm text, constraint string) pairs to the name of a method in the
	/// injected <c>IntrinsicFunctions</c> type that should be called instead of emitting a
	/// <c>throw new NotImplementedException</c> stub. The substitution method must have the
	/// exact same parameter and return types as the inline asm block it replaces.
	/// </summary>
	/// <remarks>
	/// The key is <c>(assemblyString, constraintString)</c> as extracted from the LLVM IR.
	/// The constraint string uniquely identifies arity and register layout — e.g. the seven
	/// <c>syscall</c> asm variants in llvm-libc all share the asm text <c>"syscall"</c>
	/// but differ by their constraint strings.
	/// </remarks>
	public Dictionary<
		(string Asm, string Constraints),
		string
	> InlineAssemblySubstitutions { get; init; } = new();

	public string? GetNamespace(string? subNamespace)
	{
		if (string.IsNullOrEmpty(Namespace))
		{
			return string.IsNullOrEmpty(subNamespace) ? null : subNamespace;
		}
		else if (string.IsNullOrEmpty(subNamespace))
		{
			return Namespace;
		}
		else
		{
			return $"{Namespace}.{subNamespace}";
		}
	}
}
