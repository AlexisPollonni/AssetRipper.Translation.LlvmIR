using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Roundhk
{
	[MangledName("roundhk")]
	[DemangledName("roundhk")]
	public static short Invoke([MangledName("x")] short X, [MangledName("n")] int N)
	{
		return Fixed_point_round_short_Accum.Invoke(X, N);
	}
}
