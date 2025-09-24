using Cake.Core;
using Cake.Core.Annotations;
using Cake.Core.IO;
using System.Diagnostics.CodeAnalysis;

namespace AssetRipper.Translation.LlvmIR.Build.Scripts.Tooling
{
#pragma warning disable CS9107
	[SuppressMessage("ReSharper", "RedundantNameQualifier")]
	public static class DotNetFileRunAliases
	{
		[CakeMethodAlias]
		[CakeAliasCategory("FileRun")]
		[CakeNamespaceImport("AssetRipper.Translation.LlvmIR.Build.Scripts.Tooling")]
		public static void DotNetRunFile(this ICakeContext context,
		                                 FilePath scriptsFile,
		                                 ProcessArgumentBuilder? arguments = null,
		                                 DotNetFileRunSettings? settings = null)
		{
			ArgumentNullException.ThrowIfNull(context);

			settings ??= new();
			arguments ??= new();

			var runner = new DotNetFileRunner(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			runner.Run(scriptsFile, arguments, settings);
		}
	}
}
