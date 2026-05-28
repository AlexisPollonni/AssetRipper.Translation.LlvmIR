using AsmResolver.DotNet;
using ICSharpCode.Decompiler.CSharp;
using ICSharpCode.Decompiler.CSharp.ProjectDecompiler;
using ICSharpCode.Decompiler.CSharp.Syntax;
using ICSharpCode.Decompiler.CSharp.Transforms;
using ICSharpCode.Decompiler.Metadata;
using ICSharpCode.Decompiler.TypeSystem;
using System.Runtime.CompilerServices;
using System.Text;

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
		Settings.RemoveDeadCode = true;
		Settings.AlwaysUseGlobal = true;
		Settings.AutoLoadAssemblyReferences = true;
	}

	protected override CSharpDecompiler CreateDecompiler(DecompilerTypeSystem ts)
	{
		CSharpDecompiler decompiler = base.CreateDecompiler(ts);
		decompiler.AstTransforms.Add(PartialInjectionTransform.Instance);
		return decompiler;
	}

	protected override TextWriter CreateFile(string path)
	{
		return new MemoryBufferedFileWriter(path);
	}

	private static UniversalAssemblyResolver CreateAssemblyResolver()
	{
		UniversalAssemblyResolver assemblyResolver = new(null, true, ".NETCoreApp,Version=v9.0");
		assemblyResolver.AddSearchDirectory(AppContext.BaseDirectory); // for any NuGet references
		return assemblyResolver;
	}

	/// <summary>
	/// Decompiles the module and writes the generated project file to <c>&lt;projectName&gt;.csproj</c>.
	/// If <paramref name="customProjectFileContent"/> is provided, that content is written instead
	/// of the decompiler-generated project XML.
	/// </summary>
	public void DecompileProject(
		ModuleDefinition module,
		string outputDirectory,
		string projectName,
		string? customProjectFileContent = null)
	{
		using StringWriter projectWriter = new();
		DecompileProject(module, outputDirectory, projectWriter);

		string projectContent = string.IsNullOrEmpty(customProjectFileContent)
			? projectWriter.ToString()
			: customProjectFileContent;

		string projectPath = Path.Combine(outputDirectory, $"{projectName}.csproj");
		File.WriteAllText(projectPath, projectContent, new UTF8Encoding(false));
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

	private sealed class MemoryBufferedFileWriter : StringWriter
	{
		private readonly string _path;
		private bool _written;

		public MemoryBufferedFileWriter(string path)
		{
			_path = path;
			NewLine = "\n";
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && !_written)
			{
				_written = true;
				File.WriteAllText(_path, ToString(), new UTF8Encoding(false));
			}

			base.Dispose(disposing);
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
}
