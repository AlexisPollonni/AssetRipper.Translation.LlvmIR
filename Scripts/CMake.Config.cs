#:sdk Cake.Sdk

#:project Tooling/Build.Scripts.Tooling.csproj

#:package Cake.CMake


//Required parameters
var sourcePath = Argument<DirectoryPath>("sourcePath");
var binaryPath = Argument<DirectoryPath>("binaryPath");

var generator = Argument("generator", "Ninja");
var defines = Argument<Dictionary<string, string>>("defines", []);
var undefines = Argument<List<string>>("undefines", []);
var installPrefix = Argument<DirectoryPath?>("installPrefix", null);


if (IsRunningOnWindows())
{
    defines.TryAdd("CMAKE_C_COMPILER", "clang-cl");
    defines.TryAdd("CMAKE_CXX_COMPILER", "clang-cl");
    defines.TryAdd("CMAKE_ASM_COMPILER", "clang-cl");

    defines.TryAdd("CMAKE_SHARED_LINKER_FLAGS", "-fuse-ld=lld");
    defines.TryAdd("CMAKE_EXE_LINKER_FLAGS", "-fuse-ld=lld");

    defines.TryAdd("CMAKE_C_FLAGS", "-m64");
    defines.TryAdd("CMAKE_CXX_FLAGS", "-m64");
}
else if (IsRunningOnUnix())
{
    defines.TryAdd("CMAKE_C_COMPILER", "clang");
    defines.TryAdd("CMAKE_CXX_COMPILER", "clang++");
    defines.TryAdd("CMAKE_ASM_COMPILER", "clang");

    defines.TryAdd("CMAKE_C_FLAGS", "-fPIC");
    defines.TryAdd("CMAKE_CXX_FLAGS", "-fPIC");
}

if (installPrefix is not null)
{
    defines["CMAKE_INSTALL_PREFIX"] = installPrefix.FullPath;
}

var settings = new CMakeSettings
{
    SourcePath = sourcePath,
    OutputPath = binaryPath,
    Generator = generator,
    Options = [
        ..defines.Select(d => $"-D{d.Key}={d.Value}"),
        ..undefines.Select(u => $"-U{u}")],
};

if (IsRunningOnWindows())
{
    // Set the environment variables for the CMake process from vsvarsall.bat
    settings.EnvironmentVariables = GetVsVarsAll();
}

Information("Configuring CMake to generate build files in '{0}' from source '{1}'", binaryPath, sourcePath);

CMake(settings);


