using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Rounduhk
{
	[MangledName("rounduhk")]
	[DemangledName("rounduhk")]
	public static short Invoke([MangledName("x")] short X, [MangledName("n")] int N)
	{
		return Fixed_point_round_unsigned_short_Accum.Invoke(X, N);
	}
}
