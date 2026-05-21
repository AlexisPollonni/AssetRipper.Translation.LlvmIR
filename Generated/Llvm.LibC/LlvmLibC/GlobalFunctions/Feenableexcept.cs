using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Feenableexcept
{
	[MangledName("feenableexcept")]
	[DemangledName("feenableexcept")]
	public static int Invoke([MangledName("e")] int E)
	{
		return Fputil_enable_except.Invoke(E);
	}
}
