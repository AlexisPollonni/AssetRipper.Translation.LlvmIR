using System.Runtime.Versioning;
using AsmResolver.DotNet;

namespace AssetRipper.Translation.LlvmIR.LibCBuilder.Stages;

/// <summary>
/// Runs the LLVM IR → .NET translator in-process and decompiles the result to C# source files.
/// <para>
/// Sentinel: <c>outputDir</c> exists and is newer than the <c>.bc</c> file → skipped
/// (unless <c>clean=true</c>).
/// </para>
/// </summary>
[SupportedOSPlatform("linux")]
internal static class TranslateStage
{
	public static void Run(
		string bcPath,
		string outputDir,
		ToolchainInfo toolchain,
		bool clean
	)
	{
		if (!clean && Directory.Exists(outputDir))
		{
			DateTime bcMtime = File.GetLastWriteTimeUtc(bcPath);
			DateTime outMtime = GetDirectoryMtime(outputDir);
			if (outMtime >= bcMtime)
			{
				Console.WriteLine("[Translate] Output is up to date, skipping.");
				return;
			}
		}

		if (Directory.Exists(outputDir))
		{
			Console.WriteLine("[Translate] Clearing output directory...");
			Directory.Delete(outputDir, true);
		}
		Directory.CreateDirectory(outputDir);

		Console.WriteLine("[Translate] Reading bitcode...");
		byte[] data = File.ReadAllBytes(bcPath);

		TranslatorOptions options = new()
		{
			Namespace = "LlvmLibC",
			ModuleName = "LlvmLibC",
			ClassName = "LibC",
			ParseDemangledSymbols = true,
			EmitNameAttributes = true,
			PrecomputeInitializers = false,
			StripNamePrefixes = [toolchain.StripPrefix],
			InlineAssemblySubstitutions = LibCSubstitutions.Build(),
		};

		Console.WriteLine("[Translate] Translating...");
		ModuleDefinition module = Translator.Translate("LlvmLibC", data, options);

		Console.WriteLine("[Translate] Decompiling to C#...");
		new TranslationProjectDecompiler().DecompileProject(module, outputDir, TextWriter.Null);

		Console.WriteLine("[Translate] Done.");
	}

	private static DateTime GetDirectoryMtime(string dir)
	{
		DateTime max = DateTime.MinValue;
		foreach (string f in Directory.EnumerateFiles(dir, "*", SearchOption.AllDirectories))
		{
			DateTime t = File.GetLastWriteTimeUtc(f);
			if (t > max)
			{
				max = t;
			}
		}
		return max;
	}
}
