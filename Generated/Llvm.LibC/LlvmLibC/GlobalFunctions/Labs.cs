using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Labs
{
	[MangledName("labs")]
	[DemangledName("labs")]
	public static long Invoke([MangledName("n")] long N)
	{
		return Integer_abs_long_zg646g.Invoke(N);
	}
}
