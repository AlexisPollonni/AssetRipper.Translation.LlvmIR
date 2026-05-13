using System.Diagnostics;
using System.Runtime.Versioning;

namespace AssetRipper.Translation.LlvmIR.LibCBuilder.Stages;

/// <summary>
/// Writes (or updates) a <c>Llvm.LibC.csproj</c> file in the output directory so the generated
/// code can be built as a standalone .NET 10 project.
/// <para>
/// The generated code uses unsafe pointers and intentional arithmetic overflow, so
/// <c>AllowUnsafeBlocks</c> is enabled and <c>CheckForOverflowUnderflow</c> is explicitly
/// disabled even though the solution-wide <c>Directory.Build.props</c> enables it.
/// </para>
/// </summary>
[SupportedOSPlatform("linux")]
internal static class ProjectFileStage
{
	private const string CsprojName = "Llvm.LibC.csproj";

	private static string BuildCsprojContent() =>
		"""
			<Project Sdk="Microsoft.NET.Sdk">

			  <PropertyGroup>
			    <TargetFramework>net10.0</TargetFramework>
			    <Nullable>enable</Nullable>
			    <ImplicitUsings>enable</ImplicitUsings>
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

	public static void Run(string outputDir, bool verifyBuild)
	{
		string csprojPath = Path.Combine(outputDir, CsprojName);

		Console.WriteLine("[ProjectFile] Writing Llvm.LibC.csproj...");
		File.WriteAllText(csprojPath, BuildCsprojContent());

		if (verifyBuild)
		{
			VerifyBuild(csprojPath);
		}
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
