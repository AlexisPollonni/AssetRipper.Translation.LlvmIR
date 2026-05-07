using System.ComponentModel;
using System.Runtime.Versioning;
using Ookii.CommandLine;

namespace AssetRipper.Translation.LlvmIR.LibCBuilder;

[GeneratedParser]
[ParseOptions(IsPosix = true)]
[SupportedOSPlatform("linux")]
internal sealed partial class Arguments
{
	[CommandLineArgument]
	[Description(
		"Output directory for the generated C# project. "
		+ "Defaults to '<solution-root>/Generated/Llvm.LibC'."
	)]
	public string? Output { get; set; }

	[CommandLineArgument]
	[Description(
		"Working directory for intermediate build artefacts (git checkout, cmake build, .bc file). "
		+ "Defaults to '$TMPDIR/AssetRipper.LibCBuilder'."
	)]
	public string? WorkDir { get; set; }

	[CommandLineArgument]
	[Description("LLVM major version to use (e.g. 20). Auto-detected from PATH when omitted.")]
	public int? LlvmVersion { get; set; }

	[CommandLineArgument]
	[Description(
		"Override the llvm-project git tag to clone (e.g. 'llvmorg-20.1.4'). "
		+ "Defaults to the tag matching the detected toolchain version."
	)]
	public string? LibcTag { get; set; }

	[CommandLineArgument]
	[Description("Delete all intermediate artefacts and rebuild from scratch.")]
	public bool Clean { get; set; }

	[CommandLineArgument]
	[Description("After generating, run 'dotnet build' on the generated project to verify it compiles.")]
	public bool VerifyBuild { get; set; }
}

