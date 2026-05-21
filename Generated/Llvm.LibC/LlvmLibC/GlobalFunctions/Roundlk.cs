using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Roundlk
{
	[MangledName("roundlk")]
	[DemangledName("roundlk")]
	public static long Invoke([MangledName("x")] long X, [MangledName("n")] int N)
	{
		return Fixed_point_round_long_Accum.Invoke(X, N);
	}
}
