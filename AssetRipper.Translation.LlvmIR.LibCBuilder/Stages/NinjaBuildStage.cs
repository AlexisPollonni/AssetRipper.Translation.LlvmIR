using System.Diagnostics;
using System.Runtime.Versioning;

namespace AssetRipper.Translation.LlvmIR.LibCBuilder.Stages;

/// <summary>
/// Runs <c>ninja libc</c> inside the cmake build directory to produce
/// <c>libc/lib/libllvmlibc.a</c>.
/// <para>
/// Sentinel: <c>libllvmlibc.a</c> exists and is newer than the source directory →
/// already built, skipped.
/// </para>
/// </summary>
[SupportedOSPlatform("linux")]
internal static class NinjaBuildStage
{
	public static string Run(string workDir, bool clean)
	{
		string buildDir = Path.Combine(workDir, "build");
		// The runtimes standalone build places the archive under libc/lib/ (not lib/)
		// because the runtimes CMakeLists.txt nests output under a per-component subdirectory.
		string archivePath = Path.Combine(buildDir, "libc", "lib", "libllvmlibc.a");

		if (clean && File.Exists(archivePath))
		{
			Console.WriteLine("[Ninja] --clean: deleting existing archive...");
			File.Delete(archivePath);
		}

		if (File.Exists(archivePath))
		{
			string srcDir = Path.Combine(workDir, "src");
			DateTime archiveMtime = File.GetLastWriteTimeUtc(archivePath);
			DateTime srcMtime = GetDirectoryMtime(srcDir);
			if (archiveMtime >= srcMtime)
			{
				Console.WriteLine("[Ninja] Archive is up to date, skipping build.");
				return archivePath;
			}
		}

		Console.WriteLine("[Ninja] Building llvm-libc...");
		ProcessStartInfo psi = new("ninja")
		{
			Arguments = "libc",
			WorkingDirectory = buildDir,
			UseShellExecute = false,
		};
		using Process proc =
			Process.Start(psi) ?? throw new InvalidOperationException("Failed to start 'ninja'.");
		proc.WaitForExit();
		if (proc.ExitCode != 0)
		{
			throw new InvalidOperationException($"ninja exited with code {proc.ExitCode}.");
		}

		if (!File.Exists(archivePath))
		{
			throw new InvalidOperationException(
				$"Build succeeded but expected archive not found: {archivePath}"
			);
		}

		Console.WriteLine("[Ninja] Done.");
		return archivePath;
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
