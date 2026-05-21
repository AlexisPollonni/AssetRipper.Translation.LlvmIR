using System.Diagnostics;
using System.Runtime.Versioning;

namespace AssetRipper.Translation.LlvmIR.LibCBuilder.Stages;

/// <summary>
/// Sparse-clones the llvm-project repository to <c>work-dir/src/</c> and checks out only the
/// subdirectories needed to build llvm-libc.
/// <para>
/// Sentinel: <c>work-dir/src/.git/refs/tags/&lt;tag&gt;</c> exists →
/// the correct tag is already checked out and the stage is skipped.
/// </para>
/// </summary>
[SupportedOSPlatform("linux")]
internal static class GitStage
{
	/// <summary>Paths to include in the sparse checkout (relative to repo root).</summary>
	private static readonly string[] SparsePaths =
	[
		"libc/",
		"cmake/",
		"llvm/cmake/",
		"llvm/utils/llvm-lit/",
		"runtimes/",
	];

	private const string RemoteUrl = "https://github.com/llvm/llvm-project.git";

	public static void Run(string workDir, string tag, bool clean)
	{
		string srcDir = Path.Combine(workDir, "src");
		string sentinelFile = Path.Combine(srcDir, ".git", "refs", "tags", tag);

		if (clean && Directory.Exists(srcDir))
		{
			Console.WriteLine("[Git] --clean: deleting existing source checkout...");
			Directory.Delete(srcDir, true);
		}

		if (File.Exists(sentinelFile))
		{
			Console.WriteLine($"[Git] Source already at {tag}, skipping clone.");
			return;
		}

		Directory.CreateDirectory(srcDir);

		Console.WriteLine($"[Git] Initialising sparse checkout for {tag}...");

		// Remove any previous incomplete checkout state
		if (Directory.Exists(Path.Combine(srcDir, ".git")))
		{
			Directory.Delete(srcDir, true);
			Directory.CreateDirectory(srcDir);
		}

		Run(srcDir, "git", "init");
		Run(srcDir, "git", "remote add origin " + RemoteUrl);
		Run(srcDir, "git", "config core.sparseCheckout true");
		Run(srcDir, "git", "sparse-checkout init --cone");
		Run(srcDir, "git", "sparse-checkout set " + string.Join(' ', SparsePaths));

		Console.WriteLine($"[Git] Fetching tag {tag} (depth=1)...");
		Run(srcDir, "git", $"fetch --depth=1 origin tag {tag}");

		Console.WriteLine("[Git] Checking out...");
		Run(srcDir, "git", $"checkout {tag}");

		Console.WriteLine("[Git] Done.");
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
				$"Command '{exe} {args}' exited with code {proc.ExitCode}."
			);
		}
	}
}

