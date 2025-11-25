#:sdk Cake.Sdk

#:package Cake.FileHelpers
#:package ConsoleAppFramework
#:package System.CommandLine

#:project Tooling/Build.Scripts.Tooling.csproj
#:project ../AssetRipper.Translation.LlvmIR/AssetRipper.Translation.LlvmIR.csproj

#:property AllowUnsafeBlocks=true

using System.CommandLine;
using System.CommandLine.Parsing;
using System.Diagnostics;
using System.Text.Json.Serialization;
using ConsoleAppFramework;
using LLVMSharp.Interop;
using NuGet.Packaging;
using Shouldly;

ConsoleApp.Run(args, Compile);

/// <summary>
///     Compiles a large project using compile_commands.json to a single LLVM bitcode file.
/// </summary>
/// <param name="compileCommandsJson">Path to compile_commands.json</param>
/// <param name="outputDir">Directory to place compiled .bc file</param>
/// <param name="excludePrefixes">List of prefixes to exclude from linking. For example, "C:\Program Files (x86)\Microsoft Visual Studio\" to exclude system libraries.</param>
static int Compile(
	[Argument] string compileCommandsJson,
	[Argument] string outputDir,
	string[]? excludePrefixes = null
)
{
	//TODO: Test this on linux and macOS
	var compileCommandsJsonPath = File(compileCommandsJson).Path;
	var outputDirPath = Directory(outputDir).Path;
	var excludePrefixesPaths = excludePrefixes?.Select(d => Directory(d).Path).ToArray();

	FileExists(compileCommandsJsonPath)
		.ShouldBeTrue("The compile_commands.json file does not exist.");

	EnsureDirectoryExists(outputDirPath);
	//TODO: Maybe change to a file path instead of output directory?
	var outputFile = outputDirPath.CombineWithFilePath("final.bc");

	var compileCommandsContent = FileReadText(compileCommandsJsonPath);

	compileCommandsContent.ShouldNotBeNullOrWhiteSpace("The compile_commands.json file is empty.");

	var jsonOptions = new JsonSerializerOptions { WriteIndented = false };
	jsonOptions.Converters.AddRange(
		[new FilePathJsonConverter(), new DirectoryPathJsonConverter(), new CommandJsonConverter()]
	);

#pragma warning disable IL2026, IL3050
	var compileCommands =
		JsonSerializer.Deserialize<CompileCommand[]>(compileCommandsContent, jsonOptions) ?? [];
#pragma warning restore IL2026, IL3050

	var bcFiles = compileCommands
		.DistinctBy(c => c.Output)
		.Where(c => ShouldInclude(c.File))
		.Where(c =>
		{
			var compiler = File(c.Command[0]);
			FileExists(compiler).ShouldBeTrue($"The compiler '{compiler}' does not exist.");

			return compiler
				.Path.GetFilenameWithoutExtension()
				.ToString()
				.Contains("clang", StringComparison.OrdinalIgnoreCase);
		})
		.Select(c =>
		{
			var transformedOutput = outputDirPath.CombineWithFilePath(
				c.File.GetFilename().ChangeExtension(".bc")
			);
			return c with
			{
				Output = transformedOutput,
				Command = RewriteCommand(c.Command, c.File, transformedOutput, c.Output),
			};
		})
		.ToArray();

	var testFirstcmd = string.Join(" ", bcFiles.First().Command);

	var toCompile = ExcludeUpToDateCompile(bcFiles).ToArray();

	if (toCompile.Length == 0)
	{
		Information("All files are up to date. No compilation needed.");
	}

	foreach (var skipped in bcFiles.Except(toCompile))
	{
		Information($"Skipping: {compileCommandsJsonPath.GetRelativePath(skipped.File)}");
	}

	var vsvars = GetVsVarsAll();

	try
	{
		toCompile
			.Index()
			.AsParallel()
			.ForAll(c =>
			{
				Information(
					$"[{c.Index}/{toCompile.Length}] Compiling {compileCommandsJsonPath.GetRelativePath(c.Item.File)} -> {outputDirPath.GetRelativePath(c.Item.Output)}"
				);

				var settings = new ProcessSettings
				{
					Timeout = (int?)TimeSpan.FromSeconds(15).TotalMilliseconds,
					Arguments = c.Item.Command.Skip(1).ToProcessArguments(),
					EnvironmentVariables = vsvars,
				};

				StartProcess(c.Item.Command[0], settings);

				if (!FileExists(c.Item.Output))
					Warning($"The output bitcode file was not created: {c.Item.Output}");
			});

		// Merge all produced bitcode files into the final module
		LinkModulesToFinal(bcFiles.Select(c => c.Output), outputFile);
	}
	finally
	{
		DeleteFiles(bcFiles.Select(c => c.Output));
	}

	return 0;

	bool ShouldInclude(FilePath path)
	{
		if (excludePrefixesPaths is null)
			return true;

		return !excludePrefixesPaths.Any(prefix => IsFileUnderDirectory(path, prefix));
	}

	static bool IsFileUnderDirectory(FilePath file, DirectoryPath directory)
	{
		var absDir = directory.MakeAbsolute(Context.Environment);
		var cur = file.MakeAbsolute(Context.Environment).GetDirectory();

		while (cur is not null)
		{
			if (cur == absDir)
				return true;
			cur = cur.GetParent();
		}
		return false;
	}
}

//TODO: Use in compile to find main modules
unsafe static bool ContainsMainFunction(LLVMModuleRef module)
{
	return module.GetNamedFunction("main") != default;
}

static List<string> RewriteCommand(
	IEnumerable<string> commandParts,
	FilePath inputPath,
	FilePath outputPath,
	FilePath originalOutputPath
)
{
	// Detect driver from compiler name
	var parts = commandParts.ToList();
	var compiler = parts.FirstOrDefault() ?? throw new InvalidOperationException("Empty command");
	var isClangCl = compiler.Contains("clang-cl", StringComparison.OrdinalIgnoreCase);
	var isGnuClang = !isClangCl && compiler.Contains("clang", StringComparison.OrdinalIgnoreCase);

	// 1) Start from filtered base args, keep order
	var filtered = parts
		.Where(p => p is not ("-TP" or "-Zi" or "--" or "-MDd"))
		.Where(p => p is not "-c" && p is not "/c")
		.Where(p => File(p) != inputPath)
		.ToList();

	// 2) Remove any existing output specs (-o <file>, /Fo<file> or /Fo <file>) and direct occurrences of the original output path
	filtered = RemoveOutputSpecs(filtered, originalOutputPath);

	// 3) Replace any stray references to the original output path
	for (var i = 0; i < filtered.Count; i++)
	{
		if (
			string.Equals(
				filtered[i],
				originalOutputPath.FullPath,
				StringComparison.OrdinalIgnoreCase
			)
		)
			filtered[i] = outputPath.FullPath;
	}

	// 4) Ensure we compile to LLVM bitcode and include desired debug/name flags
	//    - clang-cl: forward to frontend via /clang:-emit-llvm
	//    - GNU clang: use -emit-llvm
	if (isClangCl)
	{
		// Forward to cc1 through the driver to ensure the flag isn't ignored in clang-cl mode
		AddIfMissing(filtered, "/clang:-Xclang");
		AddIfMissing(filtered, "/clang:-emit-llvm-bc");
	}
	else
	{
		AddIfMissing(filtered, "-emit-llvm");
	}

	var mandatory = new[]
	{
		"-w",
		"-DNOMINMAX",
		"-g",
		"-fno-discard-value-names",
		"-fstandalone-debug",
	};
	foreach (var m in mandatory)
		AddIfMissing(filtered, m);

	// 5) Insert compile-only switch near the start to minimize chance of being swallowed by -Xclang or similar
	filtered.Insert(Math.Min(1, filtered.Count), isClangCl ? "/c" : "-c");

	// 6) Add output specification appropriate for the driver
	if (isClangCl)
	{
		filtered.Add($"/Fo{outputPath.FullPath}");
	}
	else
	{
		filtered.AddRange(["-o", outputPath.FullPath]);
	}

	// 7) Finally, add the input file (use "--" only with GNU clang)
	if (isClangCl)
	{
		filtered.Add(inputPath.FullPath);
	}
	else
	{
		filtered.AddRange(["--", inputPath.FullPath]);
	}

	return filtered;
}

static List<string> RemoveOutputSpecs(List<string> args, FilePath originalOutputPath)
{
	var result = new List<string>(args.Count);
	for (var i = 0; i < args.Count; i++)
	{
		var a = args[i];

		// Drop GNU -o <file>
		if (a == "-o")
		{
			i++; // skip file
			continue;
		}

		// Drop MS-style /Fo<file> or /Fo <file>
		if (a.StartsWith("/Fo", StringComparison.OrdinalIgnoreCase))
		{
			// If it is exactly "/Fo" and the next token looks like a path, skip it too
			if (string.Equals(a, "/Fo", StringComparison.OrdinalIgnoreCase) && (i + 1) < args.Count)
			{
				i++;
			}
			continue;
		}

		// Drop any accidental bare occurrence of the original output path
		if (string.Equals(a, originalOutputPath.FullPath, StringComparison.OrdinalIgnoreCase))
		{
			continue;
		}

		result.Add(a);
	}
	return result;
}

static void AddIfMissing(List<string> list, string value)
{
	if (!list.Contains(value))
		list.Add(value);
}

static unsafe void LinkModulesToFinal(
	IEnumerable<FilePath> bitcodeFiles,
	FilePath outputmergedBitcode
)
{
	// Merge multiple LLVM bitcode files into a single module using the LLVM C API.
	// Requires all modules to be parsed in the same LLVMContext.

	var files = bitcodeFiles.Where(FileExists).ToArray();

	files.ShouldNotBeEmpty("No bitcode files were provided to link or they do not exist.");

	// Avoid disposing context/buffers due to known LLVMSharp issues (see LlvmBinaryTextConverter.cs for notes)
	using var context = LLVMContextRef.Create();

	HookLLVMContextCallback(context);

	var buffers = files.Select(LoadBufferFromFile).ToArray();

	var modules = files
		.Zip(buffers)
		.Select(
			(f, i) =>
			{
				var buffer = f.Second;

				LLVMModuleRef module = default;
				try
				{
					if (!context.TryGetBitcodeModule(buffer, out module, out var errorMessage))
						Warning(
							$"[{i}/{files.Length}] Failed to parse bitcode file '{f.First}': {errorMessage}"
						);
					else
						Information($"[{i}/{files.Length}] Loaded bitcode module '{f.First}'");
				}
				finally
				{
					LLVM.DisposeMemoryBuffer(buffer);
				}

				return (Path: f.First, Module: module);
			}
		)
		.ToArray();

	modules
		.Where(m => !m.Module.TryVerify(LLVMVerifierFailureAction.LLVMPrintMessageAction, out _))
		.ToList()
		.ForEach(m => Warning($"Module '{m.Path}' is invalid"));

	var finalModule = context.CreateModuleWithName("merged-final");

	foreach (var m in modules)
	{
		Debugger.Launch();
		Debugger.Break();
		Information(
			$"Linking module {m.Path.GetRelativePath(outputmergedBitcode.GetDirectory())} into final module."
		);
		LLVM.LinkModules2(finalModule, m.Module).ShouldBe(0, $"Failed to link modules.");
	}
}

static unsafe LLVMMemoryBufferRef LoadBufferFromFile(FilePath path)
{
	using var marshalledPath = new MarshaledString(path.FullPath);

	sbyte* errorMessage;
	LLVMOpaqueMemoryBuffer* buffer;
	var res = LLVM.CreateMemoryBufferWithContentsOfFile(marshalledPath, &buffer, &errorMessage);
	if (buffer is null)
	{
		var errStr = SpanExtensions.AsString(errorMessage) ?? "Unknown error";
		LLVM.DisposeMessage(errorMessage);
		throw new InvalidOperationException($"Failed to load bitcode file '{path}': {errStr}");
	}
	return buffer;
}

static IEnumerable<CompileCommand> ExcludeUpToDateCompile(IEnumerable<CompileCommand> commands)
{
	return commands.Where(command =>
		!FileExists(command.Output)
		|| System.IO.File.GetLastWriteTimeUtc(command.File.FullPath)
			> System.IO.File.GetLastWriteTimeUtc(command.Output.FullPath)
	);
}

static unsafe void HookLLVMContextCallback(LLVMContextRef context)
{
	static void DiagHandler(LLVMOpaqueDiagnosticInfo* diag, void* _)
	{
		var sev = LLVM.GetDiagInfoSeverity(diag);
		var msgPtr = LLVM.GetDiagInfoDescription(diag);

		var msg = SpanExtensions.AsString(msgPtr) ?? "Unknown error";
		LLVM.DisposeMessage(msgPtr);

		switch (sev)
		{
			case LLVMDiagnosticSeverity.LLVMDSError:
				Error($"[LLVM] {msg}");
				break;
			case LLVMDiagnosticSeverity.LLVMDSWarning:
				Warning($"[LLVM] {msg}");
				break;
			case LLVMDiagnosticSeverity.LLVMDSRemark:
				Information($"[LLVM] {msg}");
				break;
			case LLVMDiagnosticSeverity.LLVMDSNote:
				Verbose($"[LLVM] {msg}");
				break;
			default:
				Information($"[LLVM] {msg}");
				break;
		}
	}
	context.SetDiagnosticHandler(DiagHandler, null);

	context.SetYieldCallback(
		(LLVMOpaqueContext* ctxPtr, void* _) =>
		{
			LLVMContextRef context = ctxPtr;

			Thread.Yield();
		},
		null
	);
}

internal sealed record CompileCommand
{
	[JsonPropertyName("directory")]
	[JsonConverter(typeof(DirectoryPathJsonConverter))]
	public required DirectoryPath Directory { get; set; }

	[JsonPropertyName("command")]
	[JsonConverter(typeof(CommandJsonConverter))]
	public required List<string> Command { get; set; }

	[JsonPropertyName("file")]
	[JsonConverter(typeof(FilePathJsonConverter))]
	public required FilePath File { get; set; }

	[JsonPropertyName("output")]
	[JsonConverter(typeof(FilePathJsonConverter))]
	public required FilePath Output { get; set; }
}

// Source-generated context removed in favor of runtime converters to support external Cake types.

class FilePathJsonConverter : JsonConverter<FilePath>
{
	public override FilePath Read(
		ref Utf8JsonReader reader,
		Type typeToConvert,
		JsonSerializerOptions options
	)
	{
		var str =
			reader.GetString() ?? throw new JsonException("Expected a string value for FilePath.");
		return new FilePath(str);
	}

	public override void Write(Utf8JsonWriter writer, FilePath value, JsonSerializerOptions options)
	{
		writer.WriteStringValue(value.FullPath);
	}
}

class DirectoryPathJsonConverter : JsonConverter<DirectoryPath>
{
	public override DirectoryPath Read(
		ref Utf8JsonReader reader,
		Type typeToConvert,
		JsonSerializerOptions options
	)
	{
		var str =
			reader.GetString()
			?? throw new JsonException("Expected a string value for DirectoryPath.");
		return new DirectoryPath(str);
	}

	public override void Write(
		Utf8JsonWriter writer,
		DirectoryPath value,
		JsonSerializerOptions options
	)
	{
		writer.WriteStringValue(value.FullPath);
	}
}

class CommandJsonConverter : JsonConverter<List<string>>
{
	public override List<string> Read(
		ref Utf8JsonReader reader,
		Type typeToConvert,
		JsonSerializerOptions options
	)
	{
		var str =
			reader.GetString() ?? throw new JsonException("Expected a string value for Command.");

		return [.. CommandLineParser.SplitCommandLine(str)];
	}

	public override void Write(
		Utf8JsonWriter writer,
		List<string> value,
		JsonSerializerOptions options
	)
	{
		throw new NotImplementedException("Serialization of Command is not implemented.");
	}
}
