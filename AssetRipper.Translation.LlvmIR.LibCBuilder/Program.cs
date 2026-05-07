using System.Runtime.Versioning;
using AssetRipper.Translation.LlvmIR.LibCBuilder;
using AssetRipper.Translation.LlvmIR.LibCBuilder.Stages;
[assembly: SupportedOSPlatform("linux")]
Arguments? parsedArgs = Arguments.Parse();
if (parsedArgs is null)
{
return;
}
string workDir = parsedArgs.WorkDir
?? Path.Combine(Path.GetTempPath(), "AssetRipper.LibCBuilder");
string outputDir = parsedArgs.Output
?? Path.Combine(FindSolutionRoot(), "Generated", "Llvm.LibC");
Directory.CreateDirectory(workDir);
Directory.CreateDirectory(outputDir);
Console.WriteLine($"Work dir  : {workDir}");
Console.WriteLine($"Output dir: {outputDir}");
Console.WriteLine("[Toolchain] Detecting LLVM toolchain...");
ToolchainInfo toolchain = ToolchainInfo.Detect(parsedArgs.LlvmVersion);
Console.WriteLine(
$"[Toolchain] Found clang-{toolchain.MajorVersion} ({toolchain.FullVersion})"
+ $"  tag={toolchain.GitTag}  strip-prefix={toolchain.StripPrefix}"
);
string gitTag = parsedArgs.LibcTag ?? toolchain.GitTag;
GitStage.Run(workDir, gitTag, parsedArgs.Clean);
CmakeStage.Run(workDir, toolchain, parsedArgs.Clean);
string archivePath = NinjaBuildStage.Run(workDir, parsedArgs.Clean);
string bcPath = LinkStage.Run(workDir, archivePath, toolchain, parsedArgs.Clean);
TranslateStage.Run(bcPath, outputDir, toolchain, parsedArgs.Clean);
ProjectFileStage.Run(outputDir, parsedArgs.VerifyBuild);
Console.WriteLine("All stages completed successfully.");
static string FindSolutionRoot()
{
string? dir = AppContext.BaseDirectory;
while (dir is not null)
{
if (Directory.GetFiles(dir, "*.slnx").Length > 0)
{
return dir;
}
dir = Path.GetDirectoryName(dir);
}
return Directory.GetCurrentDirectory();
}
