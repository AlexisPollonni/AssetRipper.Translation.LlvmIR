using Cake.Common.Tools.DotNet;
using Cake.Common.Tools.DotNet.MSBuild;
using Cake.Core;
using Cake.Core.IO;
using Cake.Core.Tooling;
using Shouldly;

#pragma warning disable CS9107 // Parameter is captured into the state of the enclosing type and its value is also passed to the base constructor. The value might be captured by the base class as well.

namespace AssetRipper.Translation.LlvmIR.Build.Scripts.Tooling;

/// <summary>
/// .NET file run app CLI runner.
/// Based on Cake's DotNet runner.
/// Workaround for Cake not supporting .NET 10's 'dotnet run' script file running.
/// TODO: Remove when Cake supports .NET 10.
/// </summary>
/// <remarks>
/// Initializes a new instance of the <see cref="fileSystem" /> class.
/// </remarks>
/// <param name="environment">The file system.</param>
/// <param name="processRunner">The environment.</param>
/// <param name="tools">The process runner.</param>
/// <param name="tools">The tool locator.</param>
public sealed class DotNetFileRunner(
	IFileSystem fileSystem,
	ICakeEnvironment environment,
	IProcessRunner processRunner,
	IToolLocator tools) : DotNetTool<DotNetFileRunSettings>(fileSystem, environment, processRunner, tools)
{
	/// <summary>
	/// Runs the project using the specified path with arguments and settings.
	/// </summary>
	/// <param name="scriptFile">The target project  path.</param>
	/// <param name="arguments">The arguments.</param>
	/// <param name="settings">The settings.</param>
	public void Run(FilePath scriptFile, ProcessArgumentBuilder arguments, DotNetFileRunSettings settings)
	{
		ArgumentNullException.ThrowIfNull(settings);

		RunCommand(settings, GetArguments(scriptFile, arguments, settings));
	}

	private ProcessArgumentBuilder GetArguments(FilePath scriptFile,
	                                            ProcessArgumentBuilder arguments,
	                                            DotNetFileRunSettings settings)
	{
		var builder = CreateArgumentBuilder(settings);

		builder.Append("run");

		scriptFile.ShouldNotBeNull();
		fileSystem.Exist(scriptFile).ShouldBeTrue($"Script file '{scriptFile}' does not exist.");

		builder.AppendQuoted(scriptFile.MakeAbsolute(environment).FullPath);


		// Framework
		if (!string.IsNullOrEmpty(settings.Framework))
		{
			builder.Append("--framework");
			builder.Append(settings.Framework);
		}

		// Configuration
		if (!string.IsNullOrEmpty(settings.Configuration))
		{
			builder.Append("--configuration");
			builder.Append(settings.Configuration);
		}

		// No Restore
		if (settings.NoRestore)
		{
			builder.Append("--no-restore");
		}

		// No Build
		if (settings.NoBuild)
		{
			builder.Append("--no-build");
		}

		// Runtime
		if (!string.IsNullOrEmpty(settings.Runtime))
		{
			builder.Append("--runtime");
			builder.Append(settings.Runtime);
		}

		// Sources

		foreach (var source in settings.Sources)
		{
			builder.Append("--source");
			builder.AppendQuoted(source);
		}


		// Roll Forward Policy
		if (!(settings.RollForward is null))
		{
			builder.Append("--roll-forward");
			builder.Append(settings.RollForward.Value.ToString("F"));
		}

		// MSBuild Settings
		if (settings.MSBuildSettings != null)
		{
			builder.AppendMSBuildSettings(settings.MSBuildSettings, environment);
		}

		// Arguments
		if (!arguments.IsNullOrEmpty())
		{
			builder.Append("--");
			arguments.CopyTo(builder);
		}

		return builder;
	}
}

public class DotNetFileRunSettings : DotNetSettings
{
	/// <summary>
	/// Gets or sets a specific framework to compile.
	/// </summary>
	public string? Framework { get; set; }

	/// <summary>
	/// Gets or sets the configuration under which to build.
	/// </summary>
	public string? Configuration { get; set; }

	/// <summary>
	/// Gets or sets a value indicating whether to not do implicit NuGet package restore.
	/// This makes run faster, but requires restore to be done before run is executed.
	/// </summary>
	public bool NoRestore { get; set; }

	/// <summary>
	/// Gets or sets a value indicating whether to not do implicit build.
	/// This makes run faster, but requires build to be done before run is executed.
	/// </summary>
	public bool NoBuild { get; set; }

	/// <summary>
	/// Gets or sets the specified NuGet package sources to use during the run is executed.
	/// </summary>
	/// <remarks>
	/// Requires .NET Core 2.x or newer.
	/// </remarks>
	public ICollection<string> Sources { get; set; } = new List<string>();

	/// <summary>
	/// Gets or sets the target runtime.
	/// </summary>
	public string? Runtime { get; set; }

	/// <summary>
	/// Gets or sets additional arguments to be passed to MSBuild.
	/// </summary>
	public DotNetMSBuildSettings? MSBuildSettings { get; set; }
}
