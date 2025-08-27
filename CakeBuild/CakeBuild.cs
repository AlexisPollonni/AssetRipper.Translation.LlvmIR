using Microsoft.Build.Construction;
using Microsoft.Build.Definition;
using Microsoft.Build.Evaluation;

var target = Argument("target", "BuildLLVMShims");
var configuration = Argument("configuration", "Release");

var llvmLocalRepo = Argument("llvm-local-repo-path", new DirectoryPath("./LLVMShims/llvm-project"));
var llvmRemoteUri = Argument("llvm-remote-uri", new Uri("https://github.com/llvm/llvm-project.git"));

var solution = FindSolution();

//////////////////////////////////////////////////////////////////////
// TASKS
//////////////////////////////////////////////////////////////////////

Task("Clean")
	.WithCriteria(c => HasArgument("rebuild"))
	.Does(() =>
	{
		CleanDirectory($"./src/Example/bin/{configuration}");
	});

Task("BuildLLVMShims")
	.Does(() =>
	{
		DirectoryPath shimsSrcPath = "./LLVMShims/";
		DirectoryPath buildPath = shimsSrcPath.Combine("./cmake-build/");
		
		CMake(new()
		{
			SourcePath = shimsSrcPath,
			OutputPath = buildPath,
		});
		CMakeBuild(new()
		{
			BinaryPath = buildPath,
			Configuration = configuration,
			Targets = ["LLVMShims"],
		});
		
		var libraryFiles = GetFiles($"{buildPath}/{configuration}/**/*.{{dll,so,dylib}}");
		
		Information($"Found {libraryFiles.Count} library files:");
		foreach(var file in libraryFiles)
		{
			Information($"  - {file}");
		}

		var libFile = libraryFiles.Single();

		var slnFile = SolutionFile.Parse(solution.SlnPath.FullPath);

		var libProj = slnFile.ProjectsInOrder.Single(p => p.ProjectName == "AssetRipper.Translation.LlvmIR");

		var msbuildProj = Project.FromFile(libProj.AbsolutePath, new());

		var itemGroup = msbuildProj.Xml.ItemGroups.FirstOrDefault(e => e.Label == "NativeLibraries");
		
		itemGroup ??= msbuildProj.Xml.AddItemGroup();
		itemGroup.Label = "NativeLibraries";
		
		itemGroup.RemoveAllChildren();
		
		// Add Content item to the ItemGroup
		var contentItem = itemGroup.AddItem("Content", libFile.FullPath);
		contentItem.AddMetadata("CopyToOutputDirectory", "PreserveNewest");
		contentItem.AddMetadata("Link", $"runtimes\\win-x64\\native\\{libFile.GetFilename()}");
		
		Information($"Added library file to project: {libFile.GetFilename()}");
		
		msbuildProj.Save();
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
