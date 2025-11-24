#:sdk Cake.Sdk

#:package Cake.CMake

var binaryPath = Argument<DirectoryPath>("binaryPath");
var configuration = Argument<string>("configuration");

var settings = new CMakeBuildSettings
{
    Targets = ["clean"],
    Configuration = configuration,
    CleanFirst = false,
    BinaryPath = binaryPath,
};
CMakeBuild(settings);

DeleteFile(binaryPath.CombineWithFilePath(File("CMakeCache.txt")));