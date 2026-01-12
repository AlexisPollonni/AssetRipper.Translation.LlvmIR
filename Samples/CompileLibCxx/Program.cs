// Program that will transpile libc++ to MSIL
// Uses CMake, Clang/Ninja to compile to LLVM IR, links the bitcode files using LargeProjectCompiler
// then transpiles to MSIL using ByteCodeTranspiler

using System.Formats.Tar;
using Cake.Sdk.FluentBuilder;
using ConsoleAppFramework;
using FluentBuilder;
using Octokit;
using SharpCompress.Archives;
using SharpCompress.Archives.Tar;
using SharpCompress.Compressors.Xz;
using SharpCompress.Readers;
using Shouldly;
using File = System.IO.File;
using Task = System.Threading.Tasks.Task;

ConsoleApp.Run(args);

/// <summary>
/// Commands for compiling and transpiling libc++ to MSIL
/// </summary>
[RegisterCommands]
public class CompileLibCxxCommands(ICakeContext context)
{
	/// <summary>
	/// Compile and transpile libc++ to MSIL
	/// </summary>
	/// <param name="workingDirectory">-w, Working directory for intermediate files (default: system temp directory)</param>
	/// <param name="outputDirectory">-o, Output directory for final transpiled code (default: ./output)</param>
	/// <param name="skipClone">Skip cloning libcxx if source already exists</param>
	/// <param name="skipConfigure">Skip CMake configuration step</param>
	/// <param name="skipBuild">Skip CMake build step</param>
	/// <param name="skipLink">Skip bitcode linking step</param>
	/// <param name="skipTranspile">Skip MSIL transpilation step</param>
	[Command("compile")]
	public async Task Compile(
		string? workingDirectory = null,
		string? outputDirectory = null,
		bool skipClone = false,
		bool skipConfigure = false,
		bool skipBuild = false,
		bool skipLink = false,
		bool skipTranspile = false
	)
	{


		var buildPath = Path.Combine(workDir, "build");
		var compileCommandsJson = Path.Combine(buildPath, "compile_commands.json");
		var finalBitcodePath = Path.Combine(outDir, "final.bc");

		Console.WriteLine($"Working directory: {workDir}");
		Console.WriteLine($"Output directory: {outDir}");
		Console.WriteLine();

		// Step 1: Clone libcxx source
		if (!skipClone)
		{
			Console.WriteLine("Step 1: Cloning libcxx source...");
			await CloneLatestLibCxx(libcxxSourcePath);
		}
		else
		{
			Console.WriteLine("Step 1: Skipping clone (using existing source)");
			if (!System.IO.Directory.Exists(libcxxSourcePath))
			{
				throw new InvalidOperationException(
					$"Source directory not found: {libcxxSourcePath}. Remove --skipClone flag."
				);
			}
		}

		// Step 2: Configure CMake
		if (!skipConfigure)
		{
			Console.WriteLine("Step 2: Configuring CMake build...");
			ConfigureCMake(libcxxSourcePath, buildPath);
		}
		else
		{
			Console.WriteLine("Step 2: Skipping CMake configuration");
		}

		// Step 3: Build with CMake
		if (!skipBuild)
		{
			Console.WriteLine("Step 3: Building with CMake...");
			BuildCMake(buildPath);
		}
		else
		{
			Console.WriteLine("Step 3: Skipping CMake build");
		}

		// Step 4: Link bitcode files
		if (!skipLink)
		{
			Console.WriteLine("Step 4: Linking bitcode files...");
			LinkBitcodeFiles(compileCommandsJson, outDir);
		}
		else
		{
			Console.WriteLine("Step 4: Skipping bitcode linking");
		}

		// Step 5: Transpile to MSIL
		if (!skipTranspile)
		{
			Console.WriteLine("Step 5: Transpiling to MSIL...");
			TranspileToMSIL(finalBitcodePath, outDir);
		}
		else
		{
			Console.WriteLine("Step 5: Skipping MSIL transpilation");
		}

		Console.WriteLine();
		Console.WriteLine("Pipeline completed successfully!");
		Console.WriteLine($"Output: {outDir}");
	}

	/// <summary>
	/// Clean all intermediate compilation artifacts
	/// </summary>
	/// <param name="workingDirectory">-w, Working directory to clean (default: system temp directory)</param>
	/// <param name="cleanSource">Also delete the cloned libcxx source</param>
	[Command("clean")]
	public void Clean(string? workingDirectory = null, bool cleanSource = false)
	{
		var workDir = ResolveWorkingDirectory(workingDirectory);

		Console.WriteLine($"Cleaning working directory: {workDir}");

		var buildPath = Path.Combine(workDir, "build");
		if (System.IO.Directory.Exists(buildPath))
		{
			Console.WriteLine($"Deleting build directory: {buildPath}");
			System.IO.Directory.Delete(buildPath, true);
		}

		if (cleanSource)
		{
			var libcxxSourcePath = Path.Combine(workDir, "libcxx-source");
			if (System.IO.Directory.Exists(libcxxSourcePath))
			{
				Console.WriteLine($"Deleting source directory: {libcxxSourcePath}");
				System.IO.Directory.Delete(libcxxSourcePath, true);
			}
		}

		Console.WriteLine("Clean completed successfully!");
	}

	private async Task<DirectoryPath> CloneLatestLibCxx(
		DirectoryPath? downloadDirectory = null,
		CancellationToken token = default
	)
	{
		downloadDirectory ??= context.Environment.GetSpecialPath(SpecialPath.LocalTemp);

		// Find latest libcxx release using Octokit
		var (srcAsset, version) = await FindLatestLibCxxRelease();
		Information($"Found libcxx version: {version}");

		var cachedArchive = GetFileSet(["libcxx-*.src.tar.xz"], false, downloadDirectory)
			.FirstOrDefault(path => path.GetFilename().ToString().Contains(version));

		// Check if already downloaded
		if (cachedArchive is null)
		{
			Information("Source archive not found in cache, downloading...");
			cachedArchive = downloadDirectory.CombineWithFilePath(srcAsset.Name);
			DownloadFile(srcAsset.BrowserDownloadUrl, cachedArchive);
			Information($"Downloaded source archive to: {cachedArchive}");
		}
		else
		{
			Information($"Source archive already exists at: {cachedArchive}");
			Information("Skipping download step.");
		}

		Information($"Extracting archive to directory: {downloadDirectory}");
		var srcDir = await ExtractTarXz(cachedArchive, downloadDirectory, token);

		return srcDir;
	}

	private static async Task<(ReleaseAsset downloadUrl, string version)> FindLatestLibCxxRelease()
	{
		var client = new GitHubClient(new ProductHeaderValue("AssetRipper-CompileLibCxx"));

		Information("Fetching latest releases from GitHub...");
		var releases = await client.Repository.Release.GetAll("llvm", "llvm-project");

		// Find the latest release with a libcxx archive
		foreach (var release in releases)
		{
			// Look for libcxx-*.src.tar.xz asset
			var libcxxAsset = release.Assets.FirstOrDefault(a =>
				a.Name.StartsWith("libcxx-") && a.Name.EndsWith(".src.tar.xz")
			);

			if (libcxxAsset is null)
			{
				continue;
			}

			// Extract version from tag name (e.g., "llvmorg-21.1.6" -> "21.1.6")
			var version = release.TagName.Replace("llvmorg-", "");
			return (libcxxAsset, version);
		}

		throw new InvalidOperationException("Could not find a suitable libcxx release on GitHub");
	}

	//TODO: on next release of SharpCompress, change to use async methods
	private static async Task<DirectoryPath> ExtractTarXz(
		FilePath archivePath,
		DirectoryPath destinationPath,
		CancellationToken token = default
	)
	{
		using var archive = ArchiveFactory.Open(
			MakeAbsolute(archivePath).ToString(),
			new()
			{
				ExtensionHint = archivePath.GetExtension().TrimStart('.'),
				LookForHeader = true,
			}
		);
		
		Information("Extracting .tar.xz archive...");
		var srcFolderEntry = archive.Entries.ShouldHaveSingleItem(
			"Expected single top-level directory in libcxx archive"
		);

		srcFolderEntry.IsDirectory.ShouldBeTrue(
			"Top-level entry of libcxx archive should be a directory"
		);

		await srcFolderEntry.WriteToDirectoryAsync(
			MakeAbsolute(destinationPath).ToString(),
			new()
			{
				ExtractFullPath = true,
				Overwrite = false,
				PreserveFileTime = true,
			}, cancellationToken: token);

		var path = destinationPath.Combine(srcFolderEntry.Key!.TrimEnd('/'));

		return path;
	}

	private void ConfigureCMake(string sourcePath, string buildPath)
	{
		var libcxxPath = Path.Combine(sourcePath, "libcxx");
		if (!System.IO.Directory.Exists(libcxxPath))
		{
			throw new InvalidOperationException($"libcxx directory not found at: {libcxxPath}");
		}

		System.IO.Directory.CreateDirectory(buildPath);

		var defines = new Dictionary<string, string>
		{
			["CMAKE_EXPORT_COMPILE_COMMANDS"] = "ON",
			["CMAKE_BUILD_TYPE"] = "Debug",
			["LIBCXX_INCLUDE_BENCHMARKS"] = "OFF",
			["LIBCXX_INCLUDE_TESTS"] = "OFF",
		};

		if (OperatingSystem.IsWindows())
		{
			defines["CMAKE_C_COMPILER"] = "clang-cl";
			defines["CMAKE_CXX_COMPILER"] = "clang-cl";
			defines["CMAKE_ASM_COMPILER"] = "clang-cl";
			defines["CMAKE_SHARED_LINKER_FLAGS"] = "-fuse-ld=lld";
			defines["CMAKE_EXE_LINKER_FLAGS"] = "-fuse-ld=lld";
			defines["CMAKE_C_FLAGS"] = "-m64 -DNOMINMAX";
			defines["CMAKE_CXX_FLAGS"] = "-m64 -DNOMINMAX";
		}
		else if (OperatingSystem.IsLinux() || OperatingSystem.IsMacOS())
		{
			defines["CMAKE_C_COMPILER"] = "clang";
			defines["CMAKE_CXX_COMPILER"] = "clang++";
			defines["CMAKE_ASM_COMPILER"] = "clang";
			defines["CMAKE_C_FLAGS"] = "-fPIC -DNOMINMAX";
			defines["CMAKE_CXX_FLAGS"] = "-fPIC -DNOMINMAX";
		}

		var settings = new CMakeSettings
		{
			SourcePath = libcxxPath,
			OutputPath = buildPath,
			Generator = "Ninja",
			Options = defines.Select(d => $"-D{d.Key}={d.Value}").ToArray(),
		};

		if (OperatingSystem.IsWindows())
		{
			settings.EnvironmentVariables = context.GetVsVarsAll();
		}

		context.CMake(settings);
		Console.WriteLine("  CMake configuration completed!");
	}

	private void BuildCMake(string buildPath)
	{
		var settings = new CMakeBuildSettings
		{
			Configuration = "Debug",
			CleanFirst = false,
			BinaryPath = buildPath,
			Targets = ["all"],
		};

		if (OperatingSystem.IsWindows())
		{
			settings.EnvironmentVariables = context.GetVsVarsAll();
		}

		context.CMakeBuild(settings);
		Console.WriteLine("  CMake build completed!");
	}

	private void LinkBitcodeFiles(string compileCommandsJson, string outputDir)
	{
		if (!System.IO.File.Exists(compileCommandsJson))
		{
			throw new InvalidOperationException(
				$"compile_commands.json not found at {compileCommandsJson}"
			);
		}

		System.IO.Directory.CreateDirectory(outputDir);

		var scriptPath = Path.GetFullPath(Path.Combine("../../Scripts/LargeProjectCompiler.cs"));

		var excludePrefixes = new List<string>();
		if (OperatingSystem.IsWindows())
		{
			// Exclude Windows SDK and Visual Studio system libraries
			excludePrefixes.Add(@"C:\Program Files (x86)\Microsoft Visual Studio\");
			excludePrefixes.Add(@"C:\Program Files (x86)\Windows Kits\");
			excludePrefixes.Add(@"C:\Program Files\Microsoft Visual Studio\");
		}

		var args = new List<string> { "run", "--", compileCommandsJson, outputDir };

		foreach (var prefix in excludePrefixes)
		{
			args.Add("--excludePrefixes");
			args.Add(prefix);
		}

		Console.WriteLine($"  Running LargeProjectCompiler...");
		var exitCode = RunProcessAndGetExitCode(
			"dotnet",
			string.Join(" ", args.Select(a => a.Contains(' ') ? $"\"{a}\"" : a)),
			Path.GetDirectoryName(scriptPath)!
		);

		if (exitCode != 0)
		{
			throw new InvalidOperationException(
				$"LargeProjectCompiler failed with exit code {exitCode}"
			);
		}

		Console.WriteLine("  Bitcode linking completed!");
	}

	private void TranspileToMSIL(string finalBitcodePath, string outputDir)
	{
		if (!System.IO.File.Exists(finalBitcodePath))
		{
			throw new InvalidOperationException(
				$"Final bitcode file not found at {finalBitcodePath}"
			);
		}

		var scriptPath = Path.GetFullPath(Path.Combine("../../Scripts/ByteCodeTranspiler.cs"));
		var decompileDirectory = Path.Combine(outputDir, "Decompiled");

		var args = new List<string>
		{
			"run",
			"--",
			finalBitcodePath,
			"--outNamespace",
			"LibCxx",
			"--moduleName",
			"LibCxx",
			"--className",
			"LibCxxFunctions",
			"--decompileDirectory",
			decompileDirectory,
			"--clearDecompileDirectory",
			"true",
			"--parseDemangledSymbols",
			"true",
			"--emitNameAttributes",
			"true",
			"--precomputeInitializers",
			"true",
		};

		Console.WriteLine($"  Running ByteCodeTranspiler...");
		var exitCode = RunProcessAndGetExitCode(
			"dotnet",
			string.Join(" ", args.Select(a => a.Contains(' ') ? $"\"{a}\"" : a)),
			Path.GetDirectoryName(scriptPath)!
		);

		if (exitCode != 0)
		{
			throw new InvalidOperationException(
				$"ByteCodeTranspiler failed with exit code {exitCode}"
			);
		}

		Console.WriteLine($"  Decompiled C# code written to: {decompileDirectory}");
		Console.WriteLine("  MSIL transpilation completed!");
	}
}

public static class CMakeCompile
{
	public static CMakeConfigBuilder Create(FilePath cmakeListsPath)
	{
		var name = cmakeListsPath.GetFilename();

		name.ShouldBe(
			"CMakeLists.txt",
			$"The provided path does not point to a CMakeLists.txt file: {cmakeListsPath}"
		);

		return new CMakeConfigBuilder().UsingConstructor(cmakeListsPath);
	}

	public static CMakeConfigBuilder WithDefaultsClang(this CMakeConfigBuilder builder)
	{
		if (IsRunningOnWindows())
		{
			builder.WithEnvironmentVariables(AddVsVarsAll, true);
		}

		return builder;

		void AddVsVarsAll(IDictionaryBuilder<string, string> env)
		{
			var vsVars = GetVsVarsAll();
			foreach (var kvp in vsVars)
			{
				env[kvp.Key] = kvp.Value;
			}
		}
	}
}

[AutoGenerateBuilder]
public sealed class CMakeConfig(FilePath cmakeListsPath)
{
	public DirectoryPath? BuildDirectory { get; set; }

	public string? Generator { get; set; }

	public IDictionary<string, string> Definitions { get; set; } = new Dictionary<string, string>();

	public IDictionary<string, string> EnvironmentVariables { get; set; } =
		new Dictionary<string, string>();
}

public sealed class CMakeCompiler(CMakeConfig config)
{
	public async Task Configure() { }

	public async Task Build() { }
}
