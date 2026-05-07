using System.Diagnostics;
using System.Runtime.Versioning;

namespace AssetRipper.Translation.LlvmIR.LibCBuilder.Stages;

/// <summary>
/// Extracts all LLVM bitcode objects from <c>libllvmlibc.a</c> and links them into a single
/// combined <c>llvmlibc.bc</c> file using <c>llvm-link</c>.
/// <para>
/// Sentinel: <c>work-dir/llvmlibc.bc</c> exists and is newer than the archive → skipped.
/// </para>
/// </summary>
[SupportedOSPlatform("linux")]
internal static class LinkStage
{
	public static string Run(string workDir, string archivePath, ToolchainInfo toolchain, bool clean)
	{
		string bcPath = Path.Combine(workDir, "llvmlibc.bc");

		if (clean && File.Exists(bcPath))
		{
			Console.WriteLine("[Link] --clean: deleting existing .bc file...");
			File.Delete(bcPath);
		}

		if (File.Exists(bcPath))
		{
			if (File.GetLastWriteTimeUtc(bcPath) >= File.GetLastWriteTimeUtc(archivePath))
			{
				Console.WriteLine("[Link] llvmlibc.bc is up to date, skipping.");
				return bcPath;
			}
		}

		// Extract objects into a temp directory
		string extractDir = Path.Combine(workDir, "ar-extract");
		if (Directory.Exists(extractDir))
		{
			Directory.Delete(extractDir, true);
		}
		Directory.CreateDirectory(extractDir);

		Console.WriteLine("[Link] Extracting objects from archive...");
		Run(extractDir, toolchain.LlvmAr, $"x {archivePath}");

		string[] objects = Directory.GetFiles(extractDir, "*.o", SearchOption.AllDirectories);
		if (objects.Length == 0)
		{
			// Some builds use .bc directly (no .o wrapper) — try those too
			objects = Directory.GetFiles(extractDir, "*.bc", SearchOption.AllDirectories);
		}
		if (objects.Length == 0)
		{
			throw new InvalidOperationException(
				$"No object files found after extracting {archivePath}"
			);
		}

		Console.WriteLine($"[Link] Linking {objects.Length} objects into llvmlibc.bc...");
		string objectList = string.Join(' ', objects.Select(o => $"\"{o}\""));
		Run(workDir, toolchain.LlvmLink, $"{objectList} -o \"{bcPath}\"");

		// Clean up extracted objects
		Directory.Delete(extractDir, true);

		Console.WriteLine("[Link] Done.");
		return bcPath;
	}

	private static void Run(string workingDir, string exe, string args)
	{
		ProcessStartInfo psi = new(exe)
		{
			Arguments = args,
			WorkingDirectory = workingDir,
			UseShellExecute = false,
		};
		using Process proc = Process.Start(psi)
			?? throw new InvalidOperationException($"Failed to start '{exe}'.");
		proc.WaitForExit();
		if (proc.ExitCode != 0)
		{
			throw new InvalidOperationException(
				$"Command '{exe}' exited with code {proc.ExitCode}."
			);
		}
	}
}

