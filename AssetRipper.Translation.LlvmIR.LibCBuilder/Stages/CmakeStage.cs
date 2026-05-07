using System.Diagnostics;
using System.Runtime.Versioning;

namespace AssetRipper.Translation.LlvmIR.LibCBuilder.Stages;

/// <summary>
/// Configures the llvm-libc CMake build with all flags required to produce LLVM IR bitcode
/// objects that retain full DWARF debug information through ThinLTO.
/// <para>
/// Sentinel: <c>work-dir/build/CMakeCache.txt</c> exists → already configured, skipped.
/// Pass <c>clean=true</c> to force reconfiguration.
/// </para>
/// </summary>
[SupportedOSPlatform("linux")]
internal static class CmakeStage
{
	public static void Run(string workDir, ToolchainInfo toolchain, bool clean)
	{
		// The build source is the runtimes/ sub-directory, which contains the
		// standalone runtimes CMakeLists.txt.  The llvm-project root itself does
		// not have a top-level CMakeLists.txt.
		string srcDir = Path.Combine(workDir, "src", "runtimes");
		string buildDir = Path.Combine(workDir, "build");
		string cacheFile = Path.Combine(buildDir, "CMakeCache.txt");

		if (clean && Directory.Exists(buildDir))
		{
			Console.WriteLine("[CMake] --clean: deleting existing build directory...");
			Directory.Delete(buildDir, true);
		}

		if (File.Exists(cacheFile))
		{
			Console.WriteLine("[CMake] Already configured, skipping.");
			return;
		}

		Directory.CreateDirectory(buildDir);

		// These flags make clang emit LLVM bitcode objects (not native code) while preserving
		// all DWARF information that would otherwise be eliminated during LTO optimisation.
		const string dwarf =
			"-flto=thin "
			+ "-Xclang -disable-llvm-passes "
			+ "-g "
			+ "-fstandalone-debug "
			+ "-fno-discard-value-names "
			+ "-fno-eliminate-unused-debug-types";

		string cmakeArgs = string.Join(
			' ',
			$"-S {srcDir}",
			$"-B {buildDir}",
			"-G Ninja",
			$"-DCMAKE_C_COMPILER={toolchain.Clang}",
			$"-DCMAKE_CXX_COMPILER={toolchain.ClangPlusPlus}",
			"-DLLVM_ENABLE_RUNTIMES=libc",
			"-DCMAKE_BUILD_TYPE=RelWithDebInfo",
			$"-DCMAKE_C_FLAGS=\"{dwarf}\"",
			$"-DCMAKE_CXX_FLAGS=\"{dwarf}\""
		);

		Console.WriteLine("[CMake] Configuring...");
		Run(workDir, "cmake", cmakeArgs);
		Console.WriteLine("[CMake] Done.");
	}

	private static void Run(string workingDir, string exe, string args)
	{
		ProcessStartInfo psi = new(exe)
		{
			Arguments = args,
			WorkingDirectory = workingDir,
			UseShellExecute = false,
		};
		using Process proc =
			Process.Start(psi) ?? throw new InvalidOperationException($"Failed to start '{exe}'.");
		proc.WaitForExit();
		if (proc.ExitCode != 0)
		{
			throw new InvalidOperationException(
				$"Command '{exe} {args}' exited with code {proc.ExitCode}."
			);
		}
	}
}
