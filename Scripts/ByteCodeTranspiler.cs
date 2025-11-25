#:sdk Cake.Sdk

#:package Cake.FileHelpers
#:package ConsoleAppFramework
#:package Shouldly

#:project Tooling/Build.Scripts.Tooling.csproj
#:project ../AssetRipper.Translation.LlvmIR/AssetRipper.Translation.LlvmIR.csproj

using AssetRipper.Translation.LlvmIR;
using ConsoleAppFramework;
using NuGet.Packaging;
using Shouldly;

ConsoleApp.Run(args, Run);

/// <summary>
/// Runs the LLVM IR to .NET assembly transpilation process.
/// </summary>
/// <param name="inputByteCodePath">The path to the input LLVM IR bytecode file.</param>
/// <param name="outNamespace">The root namespace to use for the generated assembly.</param>
/// <param name="moduleName">The module name to use for the generated assembly.</param>
/// <param name="className">The public class name to use in the generated assembly.</param>
/// <param name="mangledNames">The set of mangled names.</param>
/// <param name="newNames">The set of new names.</param>
/// <param name="decompileDirectory">The path to the output directory for C# decompilation. If provided, a dll will not be saved.</param>
/// <param name="clearDecompileDirectory">If true, the contents of the decompile directory will be deleted before decompilation starts.</param>
/// <param name="parseDemangledSymbols">If true, demangled names will be parsed in order to extract additional information.</param>
/// <param name="emitNameAttributes">If true, name attributes will be included in the output.</param>
/// <param name="precomputeInitializers">If true, constant structs and arrays will be initialized from precomputed binary data.</param>
void Run(
	[Argument] string inputByteCodePath,
	string outNamespace = "",
	string moduleName = "",
	string className = "",
	string[]? mangledNames = null,
	string[]? newNames = null,
	string decompileDirectory = "",
	bool clearDecompileDirectory = false,
	bool parseDemangledSymbols = true,
	bool emitNameAttributes = true,
	bool precomputeInitializers = false
)
{
	mangledNames ??= [];
	newNames ??= [];

	mangledNames.Length.ShouldBe(
		newNames.Length,
		"The number of mangled names must be the same as the number of new names"
	);

	var inputFile = File(inputByteCodePath).Path;

	var name = inputFile.GetFilenameWithoutExtension().ToString();
	var data = System.IO.File.ReadAllBytes(inputFile.FullPath);

	TranslatorOptions options = new()
	{
		Namespace = outNamespace,
		ModuleName = moduleName,
		ClassName = className,
		ParseDemangledSymbols = parseDemangledSymbols,
		EmitNameAttributes = emitNameAttributes,
		PrecomputeInitializers = precomputeInitializers,
	};

	var renamedSymbols = mangledNames.Zip(newNames).ToDictionary();

	options.RenamedSymbols.AddRange(renamedSymbols);

	var moduleDefinition = Translator.Translate(name, data, options);
	if (string.IsNullOrEmpty(decompileDirectory))
	{
		Console.WriteLine("Writing assembly...");
		moduleDefinition.Write($"{moduleDefinition.Name}.dll");
	}
	else
	{
		Console.WriteLine("Decompiling assembly...");
		if (clearDecompileDirectory && DirectoryExists(decompileDirectory))
		{
			DeleteDirectory(decompileDirectory, new() { Recursive = true });
		}
		CreateDirectory(decompileDirectory);
		new TranslationProjectDecompiler().DecompileProject(
			moduleDefinition,
			decompileDirectory,
			TextWriter.Null
		);
	}
	Console.WriteLine("Done!");
}
