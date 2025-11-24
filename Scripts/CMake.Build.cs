#:sdk Cake.Sdk

#:project Tooling/Build.Scripts.Tooling.csproj

#:package Cake.CMake

var binaryPath = Argument<DirectoryPath>("binaryPath");
var configuration = Argument<string>("configuration");
var targets = Arguments("target", "all");

var settings = new CMakeBuildSettings
{
	Configuration = configuration,
	CleanFirst = false,
	BinaryPath = binaryPath,
	Targets = targets,
};

if (IsRunningOnWindows())
{
	// Set the environment variables for the CMake process from vsvarsall.bat
	settings.EnvironmentVariables = GetVsVarsAll();
}

CMakeBuild(settings);
