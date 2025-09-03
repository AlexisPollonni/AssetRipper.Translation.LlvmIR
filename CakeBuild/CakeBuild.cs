using Microsoft.Build.Evaluation;
using Microsoft.Build.Locator;
using Shouldly;

MSBuildLocator.RegisterDefaults();

var target = Argument("target", "CopyNativeBinariesToProject");
var configuration = Argument("configuration", "Release");
var targetRid = Argument("targetRid", GetMsBuildRid());
var currentProjectName = Argument("currentProject", "AssetRipper.Translation.LlvmIR");

DirectoryPath llvmShimsSrcPath = "./LLVMShims/";
var artifactsPath = FindArtifactsFolder();
var cmakeBuildPath = artifactsPath.Combine("./obj/LLVMShims/cmake-build/");

//////////////////////////////////////////////////////////////////////
// TASKS
//////////////////////////////////////////////////////////////////////

Task("Clean")
	.WithCriteria(c => HasArgument("rebuild"))
	.Does(() =>
	{
		CleanDirectory($"./src/Example/bin/{configuration}");
	});

Task("ConfigLLVMShims")
	.Does(() =>
	{
		Information($"Building LLVM shims to {cmakeBuildPath}");
		CMake(new()
		{
			SourcePath = llvmShimsSrcPath,
			OutputPath = cmakeBuildPath,
			EnvironmentVariables =
			{
				{ "MSBUILD_EXE_PATH", "" }, { "MSBuildExtensionsPath", "" }, { "MSBuildSDKsPath", "" },
			}
		});
	});

Task("BuildLLVMShims")
	.IsDependentOn("ConfigLLVMShims")
	.Does(() =>
	{
  CMakeBuild(new()
		{
			BinaryPath = cmakeBuildPath,
			Configuration = configuration,
   Targets = ["LLVMShims"],
			CleanFirst = false,
			EnvironmentVariables =
			{
				{ "IgnoreWarnIntDirInTempDetected", "true" },
				{"MSBUILD_EXE_PATH", ""},
				{"MSBuildExtensionsPath", ""},
				{"MSBuildSDKsPath", ""},
			},
		});
	});

Task("CopyNativeBinariesToProject")
	.IsDependentOn("BuildLLVMShims")
	.Does(() =>
	{
  var libraryFiles = GetFiles($"{cmakeBuildPath}/{configuration}/**/*.{{dll,so,dylib}}");

		Information($"Current platform RID: {targetRid}");
		Information($"Found {libraryFiles.Count} library files:");
		foreach (var file in libraryFiles)
		{
			Information($"  - {file}");
		}

		var msbuildProj = FindProject(currentProjectName);

		DirectoryPath outDir = msbuildProj.GetPropertyValue("OutDir").ShouldNotBeNull();
		var nativeDir = outDir.Combine($"./runtimes/{targetRid}/native/");
		EnsureDirectoryExists(nativeDir);

		CopyFiles(libraryFiles, nativeDir);
		Information($"Copied library files to {nativeDir}");
		
		
	});

Task("Build")
	.IsDependentOn("Clean")
	.IsDependentOn("BuildLLVMShims")
	.Does(() =>
	{
		DotNetBuild("./src/Example.sln", new() { Configuration = configuration, });
	});

Task("Test")
	.IsDependentOn("Build")
	.Does(() =>
	{
		DotNetTest("./src/Example.sln", new() { Configuration = configuration, NoBuild = true, });
	});

//////////////////////////////////////////////////////////////////////
// EXECUTION
//////////////////////////////////////////////////////////////////////

RunTarget(target);
return;


(FilePath SlnPath, IReadOnlyCollection<SolutionProject> Projects) FindSolution()
{
	var workingDir = new DirectoryInfo(Environment.CurrentDirectory);

	FileInfo? slnFile = null;
	while (workingDir is not null)
	{
		slnFile = workingDir.EnumerateFiles("*.sln", SearchOption.TopDirectoryOnly).FirstOrDefault();
		if (slnFile is not null)
		{
			break;
		}

		workingDir = workingDir.Parent;
	}

	return slnFile is null
		? throw new FileNotFoundException("Could not find solution file")
		: (slnFile.FullName, ParseSolution(slnFile.FullName).Projects);
}

Project FindProject(string name)
{
	var libProj = FindSolution().Projects.Single(p => p.Name == name);

	var collection = ProjectCollection.GlobalProjectCollection;
	var msbuildProj = collection.GetLoadedProjects(libProj.Path.FullPath)
		.SingleOrDefault();
	
	msbuildProj ??= collection.LoadProject(libProj.Path.FullPath);
	
	return msbuildProj;
}

DirectoryPath FindArtifactsFolder()
{
	var proj = FindProject("CakeBuild");
	
	return proj.GetPropertyValue("ArtifactsPath");
}

string GetMsBuildRid()
{
	return FindProject("AssetRipper.Translation.LlvmIR").GetPropertyValue("RuntimeIdentifier");
}
