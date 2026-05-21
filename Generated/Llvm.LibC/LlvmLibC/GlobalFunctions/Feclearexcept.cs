using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Feclearexcept
{
	[MangledName("feclearexcept")]
	[DemangledName("feclearexcept")]
	public static int Invoke([MangledName("e")] int E)
	{
		return Fputil_clear_except.Invoke(E);
	}
}
