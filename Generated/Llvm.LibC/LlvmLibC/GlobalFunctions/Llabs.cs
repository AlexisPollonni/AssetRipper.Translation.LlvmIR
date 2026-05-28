using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Llabs
{
	[MangledName("llabs")]
	[DemangledName("llabs")]
	public static long Invoke([MangledName("n")] long N)
	{
		return Integer_abs_long_long.Invoke(N);
	}
}
