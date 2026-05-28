using System.Runtime.Versioning;
using AsmResolver.DotNet;
using System.Diagnostics;

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
	private const string ProjectContent = """
	                                      <Project Sdk="Microsoft.NET.Sdk">

	                                        <PropertyGroup>
	                                          <TargetFramework>net10.0</TargetFramework>
	                                          <Nullable>enable</Nullable>
	                                          <ImplicitUsings>false</ImplicitUsings>
	                                          <AllowUnsafeBlocks>true</AllowUnsafeBlocks>
	                                          <!-- Generated LLVM IR code uses intentional arithmetic overflow -->
	                                          <CheckForOverflowUnderflow>false</CheckForOverflowUnderflow>
	                                          <!-- Suppress DirectoryBuildProps from the solution that would re-enable overflow checks -->
	                                          <DirectoryBuildPropsPath />
	                                          <DirectoryBuildTargetsPath />
	                                        </PropertyGroup>

	                                        <ItemGroup>
	                                          <PackageReference Include="System.Numerics.Tensors" Version="10.0.0" />
	                                          <!-- Runtime helpers (IntrinsicFunctions, InlineArrayHelper, etc.) live in the Runtime assembly -->
	                                          <ProjectReference Include="../../AssetRipper.Translation.LlvmIR.Runtime/AssetRipper.Translation.LlvmIR.Runtime.csproj" />
	                                        </ItemGroup>

	                                      </Project>
	                                      """;
	
	public static void Run(
		string bcPath,
		string outputDir,
		ToolchainInfo toolchain,
		bool clean,
		bool verifyBuild
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
		new TranslationProjectDecompiler().DecompileProject(module, outputDir, "Llvm.LibC", ProjectContent);

		Console.WriteLine("[Translate] Done.");

		if (verifyBuild)
		{
			VerifyBuild(Path.Combine(outputDir, "Llvm.LibC.csproj"));
		}
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
	private static void VerifyBuild(string csprojPath)
	{
		// TODO: Replace this dotnet-build shell-out with an in-process Roslyn compilation
		// using the Microsoft.CodeAnalysis.CSharp NuGet package so that the tool has no
		// external SDK dependency and errors can be reported as structured diagnostics.
		Console.WriteLine("[ProjectFile] Running dotnet build to verify generated code...");

		ProcessStartInfo psi = new("dotnet")
		{
			Arguments = $"build \"{csprojPath}\" --nologo -v minimal",
			UseShellExecute = false,
		};
		using Process proc =
			Process.Start(psi) ?? throw new InvalidOperationException("Failed to start 'dotnet'.");
		proc.WaitForExit();

		if (proc.ExitCode == 0)
		{
			Console.WriteLine("[ProjectFile] Build succeeded.");
		}
		else
		{
			Console.WriteLine(
				$"[ProjectFile] Build failed (exit code {proc.ExitCode}). Check output above for errors."
			);
		}
	}
}

