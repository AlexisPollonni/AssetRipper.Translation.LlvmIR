using System.Runtime.Versioning;
using AssetRipper.Translation.LlvmIR.LibCBuilder;
using AssetRipper.Translation.LlvmIR.LibCBuilder.Stages;

[assembly: SupportedOSPlatform("linux")]

// ---------------------------------------------------------------------------
// AssetRipper.Translation.LlvmIR.LibCBuilder
//
// Automates the full llvm-libc → C# pipeline:
//   1. Sparse-clone llvm-project at the tag matching the detected LLVM toolchain
//   2. Configure with CMake (full DWARF debug info preserved through ThinLTO)
//   3. Build with Ninja → libllvmlibc.a
//   4. Extract + link into a single llvmlibc.bc
//   5. Translate LLVM IR to an in-memory .NET assembly       (in-process)
//   6. Decompile that assembly to C# source files            (in-process)
//   7. Write / update Llvm.LibC.csproj in the output dir
//   8. Optionally verify the generated project builds
//
// Every stage is incremental: it checks its own sentinel and skips when the
// outputs are already up-to-date.  Use --clean to force a full rebuild.
// ---------------------------------------------------------------------------

Arguments? parsedArgs = Arguments.Parse();
if (parsedArgs is null)
{
	return;
}

// ── Resolve paths ────────────────────────────────────────────────────────────

string workDir = parsedArgs.WorkDir
	?? Path.Combine(Path.GetTempPath(), "AssetRipper.LibCBuilder");

string outputDir = parsedArgs.Output
	?? Path.Combine(FindSolutionRoot(), "Generated", "Llvm.LibC");

Directory.CreateDirectory(workDir);
Directory.CreateDirectory(outputDir);

Console.WriteLine($"Work dir  : {workDir}");
Console.WriteLine($"Output dir: {outputDir}");

// ── Detect toolchain ─────────────────────────────────────────────────────────

Console.WriteLine("[Toolchain] Detecting LLVM toolchain...");
ToolchainInfo toolchain = ToolchainInfo.Detect(parsedArgs.LlvmVersion);
Console.WriteLine(
	$"[Toolchain] Found clang-{toolchain.MajorVersion} ({toolchain.FullVersion})"
		+ $"  tag={toolchain.GitTag}  strip-prefix={toolchain.StripPrefix}"
);

string gitTag = parsedArgs.LibcTag ?? toolchain.GitTag;

// ── Stage 1: Git ─────────────────────────────────────────────────────────────
GitStage.Run(workDir, gitTag, parsedArgs.Clean);

// ── Stage 2: CMake ───────────────────────────────────────────────────────────
CmakeStage.Run(workDir, toolchain, parsedArgs.Clean);

// ── Stage 3: Ninja ───────────────────────────────────────────────────────────
string archivePath = NinjaBuildStage.Run(workDir, parsedArgs.Clean);

// ── Stage 4: Link ────────────────────────────────────────────────────────────
string bcPath = LinkStage.Run(workDir, archivePath, toolchain, parsedArgs.Clean);

// ── Stage 5+6: Translate + Decompile ─────────────────────────────────────────
TranslateStage.Run(bcPath, outputDir, toolchain, parsedArgs.Clean, parsedArgs.VerifyBuild);

Console.WriteLine("All stages completed successfully.");

// ── Helpers ──────────────────────────────────────────────────────────────────

static string FindSolutionRoot()
{
	// Walk up from the running assembly's directory until we find the .slnx file.
	string? dir = AppContext.BaseDirectory;
	while (dir is not null)
	{
		if (Directory.GetFiles(dir, "*.slnx").Length > 0)
		{
			return dir;
		}
		dir = Path.GetDirectoryName(dir);
	}
	// Fall back to the current directory if no solution file is found.
	return Directory.GetCurrentDirectory();
}
