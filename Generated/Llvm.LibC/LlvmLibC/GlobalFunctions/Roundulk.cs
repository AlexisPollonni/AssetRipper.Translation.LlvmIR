using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Roundulk
{
	[MangledName("roundulk")]
	[DemangledName("roundulk")]
	public static long Invoke([MangledName("x")] long X, [MangledName("n")] int N)
	{
		return Fixed_point_round_unsigned_long_Accum.Invoke(X, N);
	}
}
