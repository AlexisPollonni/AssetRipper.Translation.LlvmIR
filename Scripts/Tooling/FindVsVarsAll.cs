using Cake.Common.IO;
using Cake.Core;
using Cake.Core.Annotations;
using Cake.Core.Diagnostics;
using Cake.Core.IO;
using NuGet.Configuration;
using Shouldly;
using System.Runtime.InteropServices;

namespace AssetRipper.Translation.LlvmIR.Build.Scripts.Tooling;

public static class FindVsVarsAll
{
	[CakeMethodAlias]
	[CakeAliasCategory("VsVarsAll")]
	[CakeNamespaceImport("AssetRipper.Translation.LlvmIR.Build.Scripts.Tooling")]
	public static IDictionary<string, string> GetVsVarsAll(this ICakeContext ctx, FilePath? pathToVsWhere = null)
	{
		var logger = ctx.Log;
		OperatingSystem.IsWindows().ShouldBeTrue("This command only works on Windows");

		ResolveVsWhereTool(pathToVsWhere);

		logger.Debug("Capturing environment variables after running vswhere");
		var vsInstallPath = GetVsInstallPath();

		var vsVarsAllPath = GetVsVarsAllPath(vsInstallPath);

		return GetVsEnvironmentVariables(vsVarsAllPath);


		FilePath ResolveVsWhereTool(FilePath? providedPathToVsWhere = null)
		{
			if (pathToVsWhere is not null)
			{
				ctx.FileExists(pathToVsWhere).ShouldBeTrue();
				pathToVsWhere.GetFilename().ShouldBe(ctx.File("vswhere.exe"));

				logger.Debug("Using vswhere at {PathToVsWhere}", pathToVsWhere);
				ctx.Tools.RegisterFile(pathToVsWhere);
				return pathToVsWhere;
			}

			var resolvedVsWhere = ctx.Tools.Resolve(["vswhere", "vswhere.exe"]);

			if (resolvedVsWhere is null)
			{
				logger.Debug("Could not find vswhere in environment or PATH");
			}
			else
			{
				logger.Information("Using vswhere from environment or PATH");
				ctx.Tools.RegisterFile(resolvedVsWhere);
				return resolvedVsWhere;
			}

			var nugetSettings
				= Settings.LoadDefaultSettings(ctx.Environment.WorkingDirectory.MakeAbsolute(ctx.Environment).FullPath);
			var globalPkgDir = ctx.Directory(SettingsUtility.GetGlobalPackagesFolder(nugetSettings));

			ctx.DirectoryExists(globalPkgDir).ShouldBeTrue();

			var searchResults = ctx.GetFiles($"{globalPkgDir}/vswhere/*/tools/vswhere.exe");

			searchResults.ShouldNotBeEmpty("Could not find vswhere in global NuGet packages");
			resolvedVsWhere = searchResults.Last();

			logger.Information("Using vswhere from NuGet package");
			ctx.Tools.RegisterFile(resolvedVsWhere);
			return resolvedVsWhere;
		}

		DirectoryPath GetVsInstallPath()
		{
			var vsWhereTool = ctx.Tools.Resolve(["vswhere", "vswhere.exe"]);
			vsWhereTool.ShouldNotBeNull();

			var output = ctx.StartProcessAndReadOutput(vsWhereTool,
			                                           args => args.Append("-prerelease")
			                                                       .Append("-latest")
			                                                       .Append("-property installationPath"))
			                .Single();

			var vsInstallPathRes = ctx.Directory(output);

			ctx.DirectoryExists(vsInstallPathRes).ShouldBeTrue();

			return vsInstallPathRes;
		}

		static FilePath GetVsVarsAllPath(DirectoryPath vsInstallPath) =>
			vsInstallPath.CombineWithFilePath("VC/Auxiliary/Build/vcvarsall.bat");

		IDictionary<string, string> GetVsEnvironmentVariables(FilePath vsVarsAll)
		{
			var cmd = ctx.Tools.Resolve(["cmd", "cmd.exe"]);

			var arch = RuntimeInformation.ProcessArchitecture switch
			{
				Architecture.X64 => "amd64",
				Architecture.X86 => "x86",
				Architecture.Arm64 => "arm64",
				Architecture.Arm => "arm",
				_ => throw new NotSupportedException($"Unsupported architecture {RuntimeInformation.ProcessArchitecture}")
			};


			var output = ctx.StartProcessAndReadOutput(vsVarsAll,
			                                           args => args.Append(arch).Append("&& set"),
			                                           additionalEnvironmentVariables: new Dictionary<string, string>
			                                           {
				                                           ["VSCMD_SKIP_SENDTELEMETRY"] = "1" // Suppress telemetry
			                                           })
			                .ToArray();

			output.ShouldNotBeEmpty();

			return output.Select(line => line.Trim())
			             .Where(trimmed => !string.IsNullOrEmpty(trimmed))
			             .Select(trimmed => trimmed.Split('=', 2))
			             .Where(parts => parts.Length == 2)
			             .Select(parts => (parts[0], parts[1]))
			             .ToDictionary();
		}
	}
}
