using System.Diagnostics;
using System.Runtime.Versioning;
using System.Text.RegularExpressions;

namespace AssetRipper.Translation.LlvmIR.LibCBuilder;

/// <summary>
/// Detects the LLVM toolchain available on PATH and derives all related names/versions.
/// </summary>
[SupportedOSPlatform("linux")]
internal sealed partial class ToolchainInfo
{
	/// <summary>Major version number, e.g. 20.</summary>
	public int MajorVersion { get; }

	/// <summary>Full semver from clang --version, e.g. "20.1.4".</summary>
	public string FullVersion { get; }

	/// <summary>Git tag for the llvm-project repo, e.g. "llvmorg-20.1.4".</summary>
	public string GitTag { get; }

	/// <summary>Prefix to strip from generated names, e.g. "llvm_libc_20_1_4_".</summary>
	public string StripPrefix { get; }

	/// <summary>Path to the clang executable, e.g. "clang-20".</summary>
	public string Clang { get; }

	/// <summary>Path to the clang++ executable, e.g. "clang++-20".</summary>
	public string ClangPlusPlus { get; }

	/// <summary>Path to the llvm-link executable, e.g. "llvm-link-20".</summary>
	public string LlvmLink { get; }

	/// <summary>Path to the llvm-ar executable, e.g. "llvm-ar-20".</summary>
	public string LlvmAr { get; }

	private ToolchainInfo(int major, string fullVersion)
	{
		MajorVersion = major;
		FullVersion = fullVersion;

		// "20.1.4" → "llvmorg-20.1.4"
		GitTag = $"llvmorg-{fullVersion}";

		// "20.1.4" → "llvm_libc_20_1_4_"
		StripPrefix = "llvm_libc_" + fullVersion.Replace('.', '_') + "_";

		Clang = $"clang-{major}";
		ClangPlusPlus = $"clang++-{major}";
		LlvmLink = $"llvm-link-{major}";
		LlvmAr = $"llvm-ar-{major}";
	}

	/// <summary>
	/// Detects the toolchain. If <paramref name="requestedMajor"/> is given, only that version is
	/// tried. Otherwise the highest available version in the range 15–30 is used.
	/// Throws <see cref="InvalidOperationException"/> if nothing is found.
	/// </summary>
	public static ToolchainInfo Detect(int? requestedMajor = null)
	{
		IEnumerable<int> candidates = requestedMajor.HasValue
			? [requestedMajor.Value]
			: Enumerable.Range(15, 16).Reverse(); // 30 down to 15

		foreach (int major in candidates)
		{
			string clang = $"clang-{major}";
			string? fullVersion = TryGetClangVersion(clang);
			if (fullVersion is not null)
			{
				return new ToolchainInfo(major, fullVersion);
			}
		}

		string msg = requestedMajor.HasValue
			? $"clang-{requestedMajor} was not found on PATH."
			: "No clang-NN executable (versions 15–30) was found on PATH.";
		throw new InvalidOperationException(msg);
	}

	private static string? TryGetClangVersion(string executable)
	{
		try
		{
			ProcessStartInfo psi = new(executable, "--version")
			{
				RedirectStandardOutput = true,
				RedirectStandardError = true,
				UseShellExecute = false,
			};
			using Process proc = Process.Start(psi)!;
			string stdout = proc.StandardOutput.ReadToEnd();
			proc.WaitForExit();
			if (proc.ExitCode != 0)
			{
				return null;
			}

			// "clang version 20.1.4 ..." or "Ubuntu clang version 20.1.4-1ubuntu1 ..."
			Match m = ClangVersionRegex().Match(stdout);
			if (!m.Success)
			{
				return null;
			}

			// Keep only MAJOR.MINOR.PATCH (drop distro suffix like "-1ubuntu1")
			return m.Groups[1].Value;
		}
		catch
		{
			return null;
		}
	}

	[GeneratedRegex(@"clang version (\d+\.\d+\.\d+)", RegexOptions.IgnoreCase)]
	private static partial Regex ClangVersionRegex();
}

