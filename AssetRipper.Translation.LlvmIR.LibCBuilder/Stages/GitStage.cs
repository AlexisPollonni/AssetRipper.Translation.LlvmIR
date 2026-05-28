using System.Diagnostics;
using System.Runtime.Versioning;

namespace AssetRipper.Translation.LlvmIR.LibCBuilder.Stages;

/// <summary>
/// Sparse-clones the llvm-project repository to <c>work-dir/src/</c> and checks out only the
/// subdirectories needed to build llvm-libc.
/// <para>
/// When <paramref name="clean"/> is <c>true</c> and the repo already exists on disk, the stage
/// resets the working tree in-place without re-downloading anything.  A network fetch is only
/// issued if the requested tag is not present in the local object database.
/// </para>
/// </summary>
[SupportedOSPlatform("linux")]
internal static class GitStage
{
	private enum RepoState
	{
		/// <summary>No git repository exists at the target directory.</summary>
		Missing,
		/// <summary>A repository exists but HEAD is not at the requested tag.</summary>
		WrongTag,
		/// <summary>A repository exists and HEAD is exactly at the requested tag.</summary>
		CorrectTag,
	}

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

		RepoState state = ProbeRepo(srcDir, tag);

		if (state == RepoState.Missing)
		{
			// Remove whatever stale content is there and start fresh.
			if (Directory.Exists(srcDir))
			{
				Console.WriteLine("[Git] Removing incomplete source directory...");
				Directory.Delete(srcDir, true);
			}
			Directory.CreateDirectory(srcDir);
			FreshSparseClone(srcDir, tag);
			return;
		}

		if (state == RepoState.CorrectTag && !clean)
		{
			Console.WriteLine($"[Git] Source already at {tag}, skipping.");
			return;
		}

		// Repo is present; reset to the requested tag without a full re-clone.
		// Re-apply sparse-checkout first so that switching tags (or recovering a repo whose
		// sparse config was lost) never expands the full llvm working tree.
		Console.WriteLine("[Git] Re-applying sparse checkout configuration...");
		ApplySparseCheckout(srcDir);

		// Only fetch from the network if the tag isn't already in the local object database.
		(int verifyExit, _) = RunGitCapture(srcDir, $"rev-parse --verify refs/tags/{tag}");
		if (verifyExit != 0)
		{
			Console.WriteLine($"[Git] Tag {tag} not in local object database, fetching from remote...");
			RunGit(srcDir, $"fetch --depth=1 origin tag {tag}");
		}

		Console.WriteLine($"[Git] Resetting working tree to {tag}...");
		RunGit(srcDir, $"checkout {tag}");
		RunGit(srcDir, "reset --hard HEAD");
		RunGit(srcDir, "clean -fdx");

		Console.WriteLine("[Git] Done.");
	}

	/// <summary>
	/// Determines the current git state of <paramref name="srcDir"/> by running git commands.
	/// Never reads internal git paths directly.
	/// </summary>
	private static RepoState ProbeRepo(string srcDir, string tag)
	{
		if (!Directory.Exists(srcDir))
		{
			return RepoState.Missing;
		}

		// Ask git for the top-level of the repo rooted at srcDir.
		// If srcDir is just *inside* another repo (e.g. the solution repo), the returned path
		// will differ from srcDir — we treat that as "no repo here".
		(int exitCode, string showTopLevel) = RunGitCapture(srcDir, "rev-parse --show-toplevel");
		if (exitCode != 0)
		{
			return RepoState.Missing;
		}

		string canonical = Path.GetFullPath(srcDir).TrimEnd(Path.DirectorySeparatorChar);
		string topLevel = Path.GetFullPath(showTopLevel.Trim()).TrimEnd(Path.DirectorySeparatorChar);
		if (!string.Equals(canonical, topLevel, StringComparison.OrdinalIgnoreCase))
		{
			return RepoState.Missing;
		}

		// Repo exists at srcDir — check whether HEAD is exactly at the requested tag.
		(exitCode, string describedTag) = RunGitCapture(srcDir, "describe --tags --exact-match HEAD");
		if (exitCode == 0 && describedTag.Trim() == tag)
		{
			return RepoState.CorrectTag;
		}

		return RepoState.WrongTag;
	}

	/// <summary>
	/// Enables cone-mode sparse checkout and sets <see cref="SparsePaths"/>.
	/// Safe to call on a repo that already has sparse checkout configured — it is idempotent.
	/// </summary>
	private static void ApplySparseCheckout(string srcDir)
	{
		RunGit(srcDir, "config core.sparseCheckout true");
		RunGit(srcDir, "sparse-checkout init --cone");
		RunGit(srcDir, "sparse-checkout set " + string.Join(' ', SparsePaths));
	}

	private static void FreshSparseClone(string srcDir, string tag)
	{
		Console.WriteLine($"[Git] Initialising sparse checkout for {tag}...");

		RunGit(srcDir, "init");
		RunGit(srcDir, "remote add origin " + RemoteUrl);
		ApplySparseCheckout(srcDir);

		Console.WriteLine($"[Git] Fetching tag {tag} (depth=1)...");
		RunGit(srcDir, $"fetch --depth=1 origin tag {tag}");

		Console.WriteLine("[Git] Checking out...");
		RunGit(srcDir, $"checkout {tag}");

		Console.WriteLine("[Git] Done.");
	}

	/// <summary>Runs a git command whose output goes directly to the console; throws on non-zero exit.</summary>
	private static void RunGit(string workingDir, string args)
	{
		ProcessStartInfo psi = new("git")
		{
			Arguments = args,
			WorkingDirectory = workingDir,
			UseShellExecute = false,
		};
		using Process proc = Process.Start(psi)
			?? throw new InvalidOperationException("Failed to start 'git'.");
		proc.WaitForExit();
		if (proc.ExitCode != 0)
		{
			throw new InvalidOperationException(
				$"git {args} exited with code {proc.ExitCode}."
			);
		}
	}

	/// <summary>
	/// Runs a git command, captures stdout, and suppresses stderr.
	/// Never throws — the caller inspects the returned exit code.
	/// </summary>
	private static (int exitCode, string stdout) RunGitCapture(string workingDir, string args)
	{
		try
		{
			ProcessStartInfo psi = new("git")
			{
				Arguments = args,
				WorkingDirectory = workingDir,
				UseShellExecute = false,
				RedirectStandardOutput = true,
				RedirectStandardError = true, // suppressed — not redirected to anything
			};
			using Process proc = Process.Start(psi)!;
			string stdout = proc.StandardOutput.ReadToEnd();
			proc.WaitForExit();
			return (proc.ExitCode, stdout);
		}
		catch
		{
			return (-1, string.Empty);
		}
	}
}
