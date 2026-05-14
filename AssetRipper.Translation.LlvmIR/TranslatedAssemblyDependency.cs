using System.Diagnostics.CodeAnalysis;
using AsmResolver.DotNet;

namespace AssetRipper.Translation.LlvmIR;

/// <summary>
/// Wraps a previously-translated .NET assembly and exposes prebuilt look-up indices for
/// resolving C++ symbols during multi-module translation.
/// </summary>
/// <remarks>
/// <para>
/// The dependency assembly must have been translated with
/// <see cref="TranslatorOptions.EmitNameAttributes"/> set to <see langword="true"/>; otherwise
/// the <c>[MangledName]</c> attributes required for index building are absent and both indices
/// remain empty.
/// </para>
/// <para>
/// Two indices are built at construction time:
/// <list type="bullet">
///   <item>
///     <term>Function index</term>
///     <description>
///       Maps C++ mangled symbol names (e.g. <c>_Z3fooii</c>) to the corresponding
///       <see cref="MethodDefinition"/> found in a public static class of the dependency (typically
///       <c>GlobalMembers</c>). Used by <c>TryResolveDependency</c> to emit
///       cross-assembly forwarding calls.
///     </description>
///   </item>
///   <item>
///     <term>Type index</term>
///     <description>
///       Maps DWARF Itanium-mangled type identifiers (e.g. <c>_ZTSN4llvm3fooE</c>) to the
///       corresponding <see cref="TypeDefinition"/>. Identifiers are read from
///       <c>[MangledName]</c> attributes on enum types (whose <see cref="EnumContext.MangledName"/>
///       is always the DWARF identifier). Struct type sharing requires to also store
///       the DWARF identifier as an attribute during translation.  Used by struct/enum type sharing
///       to reuse types across modules instead of creating local duplicates.
///     </description>
///   </item>
/// </list>
/// </para>
/// </remarks>
public sealed class TranslatedAssemblyDependency
{
	private const string MangledNameAttrNamespace =
		"AssetRipper.Translation.LlvmIR.Runtime.Attributes";
	private const string MangledNameAttrName = "MangledNameAttribute";

	private readonly ModuleDefinition _module;

	// Backing stores hold TypeDefinition/MethodDefinition objects from the dependency module.
	// Callers must import them into the target module before emitting CIL (use ImportFunctionInto /
	// ImportTypeInto, or call targetModule.DefaultImporter.Import* directly).
	private readonly IReadOnlyDictionary<string, MethodDefinition> _functionIndex;
	private readonly IReadOnlyDictionary<string, TypeDefinition> _typeIndex;

	private TranslatedAssemblyDependency(ModuleDefinition module)
	{
		_module = module;
		_functionIndex = BuildFunctionIndex(module);
		_typeIndex = BuildTypeIndex(module);
	}

	// ── Factory methods ────────────────────────────────────────────────────────────────────

	/// <summary>Load a dependency from a compiled assembly file on disk.</summary>
	/// <param name="path">Absolute or relative path to the <c>.dll</c> file.</param>
	public static TranslatedAssemblyDependency FromFile(string path) =>
		new(ModuleDefinition.FromFile(path));

	/// <summary>
	/// Wrap an already-translated in-memory module as a dependency.
	/// </summary>
	/// <remarks>
	/// Use this overload in pipelines where the dependency was produced in the same process
	/// and the <see cref="ModuleDefinition"/> is still live in memory (e.g. libc translated
	/// first, then immediately used as a dependency for libcxx in the same run).
	/// </remarks>
	/// <param name="module">The in-memory <see cref="ModuleDefinition"/> to wrap.</param>
	public static TranslatedAssemblyDependency FromModule(ModuleDefinition module) => new(module);

	// ── Public properties ──────────────────────────────────────────────────────────────────

	/// <summary>The AsmResolver module definition for the dependency assembly.</summary>
	public ModuleDefinition Module => _module;

	/// <summary>Number of public functions indexed from the dependency.</summary>
	public int FunctionCount => _functionIndex.Count;

	/// <summary>Number of named types indexed from the dependency.</summary>
	public int TypeCount => _typeIndex.Count;

	/// <summary>
	/// All entries in the type index as DWARF-identifier / <see cref="TypeDefinition"/> pairs.
	/// Used by <c>BuildDwarfTypeLookup</c> to populate the type-refinement lookup table so
	/// struct-pointer and enum fields/parameters can be refined to their dependency types.
	/// </summary>
	public IEnumerable<KeyValuePair<string, TypeDefinition>> Types => _typeIndex;

	// ── Look-up methods ────────────────────────────────────────────────────────────────────

	/// <summary>
	/// Attempt to look up a C++ mangled symbol name in the function index.
	/// </summary>
	/// <param name="mangledName">The C++ mangled name, e.g. <c>_Z3fooii</c>.</param>
	/// <param name="method">
	/// When found, the <see cref="MethodDefinition"/> in the dependency for that symbol.
	/// Must be imported into the target module via
	/// <see cref="ImportFunctionInto(MethodDefinition, ModuleDefinition)"/>
	/// before being used in a CIL instruction.
	/// </param>
	/// <returns><see langword="true"/> when a match was found.</returns>
	public bool TryGetFunction(
		string mangledName,
		[NotNullWhen(true)] out MethodDefinition? method
	) => _functionIndex.TryGetValue(mangledName, out method);

	/// <summary>
	/// Attempt to look up a DWARF Itanium-mangled type identifier in the type index.
	/// </summary>
	/// <param name="dwarfIdentifier">
	/// The DWARF type identifier, e.g. <c>_ZTSN4llvm3fooE</c>.
	/// </param>
	/// <param name="type">
	/// When found, the <see cref="TypeDefinition"/> in the dependency for that type.
	/// Must be imported into the target module via
	/// <see cref="ImportTypeInto(TypeDefinition, ModuleDefinition)"/>
	/// before being used in a signature.
	/// </param>
	/// <returns><see langword="true"/> when a match was found.</returns>
	public bool TryGetType(string dwarfIdentifier, [NotNullWhen(true)] out TypeDefinition? type) =>
		_typeIndex.TryGetValue(dwarfIdentifier, out type);

	// ── Import helpers ─────────────────────────────────────────────────────────────────────

	/// <summary>
	/// Import a dependency method into <paramref name="targetModule"/> so it can be referenced
	/// in a CIL <c>call</c> instruction.
	/// </summary>
	/// <param name="method">
	/// A <see cref="MethodDefinition"/> obtained from <see cref="TryGetFunction"/>.
	/// </param>
	/// <param name="targetModule">The output module the call will be emitted into.</param>
	/// <returns>An <see cref="IMethodDefOrRef"/> suitable for a CIL call operand.</returns>
	public IMethodDefOrRef ImportFunctionInto(
		MethodDefinition method,
		ModuleDefinition targetModule
	) => targetModule.DefaultImporter.ImportMethod(method);

	/// <summary>
	/// Import a dependency type into <paramref name="targetModule"/> so it can be used in
	/// method signatures and custom attributes.
	/// </summary>
	/// <param name="type">
	/// A <see cref="TypeDefinition"/> obtained from <see cref="TryGetType"/>.
	/// </param>
	/// <param name="targetModule">The output module the type reference will be emitted into.</param>
	/// <returns>An <see cref="ITypeDefOrRef"/> suitable for a type signature.</returns>
	public ITypeDefOrRef ImportTypeInto(TypeDefinition type, ModuleDefinition targetModule) =>
		targetModule.DefaultImporter.ImportType(type);

	// ── Index builders ─────────────────────────────────────────────────────────────────────

	/// <summary>
	/// Scan all public static types in <paramref name="module"/> for public static methods that
	/// carry a <c>[MangledName]</c> attribute and build a mangled-name → method dictionary.
	/// </summary>
	private static Dictionary<string, MethodDefinition> BuildFunctionIndex(ModuleDefinition module)
	{
		Dictionary<string, MethodDefinition> index = new(StringComparer.Ordinal);

		foreach (TypeDefinition type in module.TopLevelTypes)
		{
			// Only scan public static classes — CIL represents static as abstract + sealed.
			if (!type.IsPublic || !type.IsAbstract || !type.IsSealed)
			{
				continue;
			}

			foreach (MethodDefinition method in type.Methods)
			{
				if (!method.IsPublic || !method.IsStatic)
				{
					continue;
				}

				foreach (
					CustomAttribute attr in method.FindCustomAttributes(
						MangledNameAttrNamespace,
						MangledNameAttrName
					)
				)
				{
					string? mangledName = attr.Signature?.FixedArguments[0].Element?.ToString();
					if (mangledName is not null)
					{
						// First definition wins — mirrors C++ one-definition rule.
						index.TryAdd(mangledName, method);
					}
				}
			}
		}

		return index;
	}

	/// <summary>
	/// Scan all top-level types in <paramref name="module"/> for those carrying a
	/// <c>[MangledName(_ZTS…)]</c> attribute (i.e. whose mangled name is a DWARF Itanium type
	/// identifier) and build a DWARF identifier → type dictionary.
	/// </summary>
	/// <remarks>
	/// Currently this covers enum types whose
	/// <see cref="EnumContext.MangledName"/> is always the DWARF identifier.
	/// Struct type sharing requires Phase 4 changes to the translator to also emit the DWARF
	/// identifier as an attribute during struct translation.
	/// </remarks>
	private static Dictionary<string, TypeDefinition> BuildTypeIndex(ModuleDefinition module)
	{
		Dictionary<string, TypeDefinition> index = new(StringComparer.Ordinal);

		foreach (TypeDefinition type in module.TopLevelTypes)
		{
			foreach (
				CustomAttribute attr in type.FindCustomAttributes(
					MangledNameAttrNamespace,
					MangledNameAttrName
				)
			)
			{
				string? id = attr.Signature?.FixedArguments[0].Element?.ToString();
				// Only DWARF Itanium-mangled type identifiers start with "_ZTS".
				if (id is not null && id.StartsWith("_ZTS", StringComparison.Ordinal))
				{
					index.TryAdd(id, type);
				}
			}
		}

		return index;
	}
}
