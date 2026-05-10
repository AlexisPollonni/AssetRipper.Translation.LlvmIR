using AsmResolver.DotNet;
using ICSharpCode.Decompiler.CSharp;
using ICSharpCode.Decompiler.CSharp.ProjectDecompiler;
using ICSharpCode.Decompiler.CSharp.Syntax;
using ICSharpCode.Decompiler.CSharp.Transforms;
using ICSharpCode.Decompiler.Metadata;
using ICSharpCode.Decompiler.TypeSystem;

namespace AssetRipper.Translation.LlvmIR;

public class TranslationProjectDecompiler : WholeProjectDecompiler
{
	public TranslationProjectDecompiler()
		: base(CreateAssemblyResolver())
	{
		Settings.SetLanguageVersion(LanguageVersion.Latest);
		Settings.CheckForOverflowUnderflow = true;
		Settings.UseNestedDirectoriesForNamespaces = true;
		Settings.AggressiveInlining = true;
		Settings.RemoveDeadStores = true;
	}

	protected override CSharpDecompiler CreateDecompiler(DecompilerTypeSystem ts)
	{
		CSharpDecompiler decompiler = base.CreateDecompiler(ts);
		decompiler.AstTransforms.Add(PartialInjectionTransform.Instance);
		decompiler.AstTransforms.Add(QualifyConflictingTypeNamesTransform.Instance);
		return decompiler;
	}

	protected override TextWriter CreateFile(string path)
	{
		TextWriter result = base.CreateFile(path);
		result.NewLine = "\n"; // use LF line endings
		return result;
	}

	private static UniversalAssemblyResolver CreateAssemblyResolver()
	{
		UniversalAssemblyResolver assemblyResolver = new(null, true, ".NETCoreApp,Version=v9.0");
		assemblyResolver.AddSearchDirectory(AppContext.BaseDirectory); // for any NuGet references
		return assemblyResolver;
	}

	public void DecompileProject(
		ModuleDefinition module,
		string outputDirectory,
		TextWriter? projectFileWriter = null
	)
	{
		string file = Path.GetTempFileName();
		try
		{
			using (FileStream fileStream = new(file, FileMode.Open, FileAccess.Write))
			{
				module.Write(fileStream);
			}
			using PEFile moduleFile = new(file);
			if (projectFileWriter is null)
			{
				DecompileProject(moduleFile, outputDirectory);
			}
			else
			{
				DecompileProject(moduleFile, outputDirectory, projectFileWriter);
			}

			string propertiesDirectory = Path.Combine(outputDirectory, "Properties");
			if (Directory.Exists(propertiesDirectory))
			{
				string assemblyInfoFile = Path.Combine(propertiesDirectory, "AssemblyInfo.cs");

				if (File.Exists(assemblyInfoFile))
				{
					File.Delete(assemblyInfoFile); // remove AssemblyInfo.cs, as it is not needed
				}
				if (!Directory.EnumerateFileSystemEntries(propertiesDirectory).Any())
				{
					Directory.Delete(propertiesDirectory); // remove empty Properties directory
				}
			}
		}
		finally
		{
			File.Delete(file);
		}
	}

	private sealed class PartialInjectionTransform : IAstTransform
	{
		public static PartialInjectionTransform Instance { get; } = new();

		public void Run(AstNode rootNode, TransformContext context)
		{
			foreach (
				TypeDeclaration typeNode in rootNode.DescendantsAndSelf.OfType<TypeDeclaration>()
			)
			{
				if (typeNode.ClassType is not ClassType.Enum)
				{
					typeNode.Modifiers |= Modifiers.Partial;
				}
			}
		}
	}

	/// <summary>
	/// Replaces unqualified <see cref="SimpleType"/> references with fully-qualified
	/// <see cref="MemberType"/> chains whenever the simple name would otherwise be
	/// ambiguous with a type brought in by <c>&lt;ImplicitUsings&gt;enable&lt;/ImplicitUsings&gt;</c>.
	/// </summary>
	private sealed class QualifyConflictingTypeNamesTransform : IAstTransform
	{
		public static QualifyConflictingTypeNamesTransform Instance { get; } = new();

		// Namespaces unconditionally imported by <ImplicitUsings>enable</ImplicitUsings>
		// for SDK-style class library projects (net6+).
		private static readonly HashSet<string> ImplicitUsingNamespaces =
		[
			"System",
			"System.Collections.Generic",
			"System.IO",
			"System.Linq",
			"System.Net.Http",
			"System.Threading",
			"System.Threading.Tasks",
		];

		public void Run(AstNode rootNode, TransformContext context)
		{
			// Step 1: Collect all type names that exist in implicit-using namespaces.
			HashSet<string> implicitTypeNames = [];
			foreach (IModule module in context.TypeSystem.MainModule.Compilation.ReferencedModules)
			{
				foreach (ITypeDefinition td in module.TypeDefinitions)
				{
					if (ImplicitUsingNamespaces.Contains(td.Namespace))
					{
						implicitTypeNames.Add(td.Name);
					}
				}
			}

			if (implicitTypeNames.Count == 0)
			{
				return;
			}

			// Step 2: Find namespaces that are explicitly imported via `using` directives in
			// this file (these are the non-implicit namespaces the decompiler chose to emit).
			HashSet<string> explicitNamespaces = rootNode
				.Descendants.OfType<UsingDeclaration>()
				.Select(static ud => ud.Import.ToString())
				.ToHashSet();

			// Step 3: For each conflicting name (exists in both an explicit and an implicit
			// namespace), record which type in the explicit namespace should be used.
			// Key is (typeName, typeParameterCount) so generic/non-generic overloads are separate.
			// We include the main module itself so user-defined types are found first.
			Dictionary<(string name, int arity), IType> conflictResolution = [];
			IEnumerable<IModule> allModules =
				context.TypeSystem.MainModule.Compilation.ReferencedModules.Prepend(
					context.TypeSystem.MainModule
				);

			foreach (IModule module in allModules)
			{
				foreach (ITypeDefinition td in module.TypeDefinitions)
				{
					if (
						implicitTypeNames.Contains(td.Name)
						&& !ImplicitUsingNamespaces.Contains(td.Namespace)
						&& explicitNamespaces.Contains(td.Namespace)
					)
					{
						// Prefer the first match (main module types take priority).
						conflictResolution.TryAdd((td.Name, td.TypeParameterCount), td);
					}
				}
			}

			if (conflictResolution.Count == 0)
			{
				return;
			}

			// Step 4: Walk every SimpleType; replace any whose (identifier, arity) is conflicting.
			// We skip SimpleTypes that are inside a UsingDeclaration (those are the import targets
			// themselves and must not be touched).
			foreach (SimpleType simpleType in rootNode.Descendants.OfType<SimpleType>().ToList())
			{
				int arity = simpleType.TypeArguments.Count;
				if (
					!conflictResolution.TryGetValue(
						(simpleType.Identifier, arity),
						out IType? targetType
					)
				)
				{
					continue;
				}

				// Don't modify the SimpleType nodes that are part of `using` declarations.
				if (simpleType.Ancestors.OfType<UsingDeclaration>().Any())
				{
					continue;
				}

				// If annotation is present and already resolves to an implicit-namespace type,
				// leave it alone (genuine reference to e.g. System.Threading.Mutex).
				IType? annotatedType = simpleType.Annotation<IType>();
				if (
					annotatedType is not null
					&& ImplicitUsingNamespaces.Contains(annotatedType.Namespace)
				)
				{
					continue;
				}

				// Build the qualified form, re-attaching the original type arguments.
				var typeArgs = simpleType.TypeArguments.Select(ta => ta.Clone()).ToArray();
				AstType qualified = BuildQualifiedAstType(targetType, typeArgs);
				qualified.AddAnnotation(targetType);
				simpleType.ReplaceWith(qualified);
			}
		}

		/// <summary>Builds a chain of <see cref="MemberType"/> nodes for the given type, with optional type arguments.</summary>
		private static AstType BuildQualifiedAstType(IType type, AstType[]? typeArgs = null)
		{
			if (string.IsNullOrEmpty(type.Namespace))
			{
				var st = new SimpleType(type.Name);
				if (typeArgs is { Length: > 0 })
					foreach (AstType arg in typeArgs)
						st.TypeArguments.Add(arg);
				return st;
			}

			var mt = new MemberType(BuildNamespaceAstType(type.Namespace), type.Name);
			if (typeArgs is { Length: > 0 })
				foreach (AstType arg in typeArgs)
					mt.TypeArguments.Add(arg);
			return mt;
		}

		/// <summary>Recursively builds <see cref="MemberType"/> nodes for a dotted namespace string.</summary>
		private static AstType BuildNamespaceAstType(string ns)
		{
			int dot = ns.LastIndexOf('.');
			if (dot < 0)
			{
				return new SimpleType(ns);
			}

			return new MemberType(BuildNamespaceAstType(ns[..dot]), ns[(dot + 1)..]);
		}
	}
}
