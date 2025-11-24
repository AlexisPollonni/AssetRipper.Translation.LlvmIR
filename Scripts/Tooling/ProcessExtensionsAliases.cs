using System.Diagnostics.CodeAnalysis;
using Cake.Common;
using Cake.Core;
using Cake.Core.Annotations;
using Cake.Core.IO;

namespace AssetRipper.Translation.LlvmIR.Build.Scripts.Tooling
{
#pragma warning disable CS9107
	[SuppressMessage("ReSharper", "RedundantNameQualifier")]
	public static class ProcessExtensionsAliases
	{
		[CakeMethodAlias]
		[CakeAliasCategory("ProcessReadOutput")]
		[CakeNamespaceImport("AssetRipper.Translation.LlvmIR.Build.Scripts.Tooling")]
		public static IEnumerable<string> StartProcessAndReadOutput(
			this ICakeContext ctx,
			FilePath path,
			ArgumentHandler args,
			DirectoryPath? workingDirectory = null,
			IDictionary<string, string>? additionalEnvironmentVariables = null,
			TimeSpan? timeout = null
		)
		{
			var settings = new ProcessSettings
			{
				Arguments = args(new()),
				RedirectStandardOutput = true,
				WorkingDirectory = workingDirectory ?? ctx.Environment.WorkingDirectory,
				Timeout = (int?)timeout?.TotalMilliseconds,
				EnvironmentVariables = additionalEnvironmentVariables,
			};

			var result = ctx.StartProcess(path, settings, out var redirectedStandardOutput);

			return 0 != result
				? throw new(
					$"Failed to execute tool {path.GetFilename()} ({result}) with args: {settings.Arguments.RenderSafe()}"
				)
				: redirectedStandardOutput;
		}

		public delegate ProcessArgumentBuilder ArgumentHandler(ProcessArgumentBuilder args);
	}
}
