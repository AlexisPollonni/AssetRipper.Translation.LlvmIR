using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Roundr
{
	[MangledName("roundr")]
	[DemangledName("roundr")]
	public static short Invoke([MangledName("x")] short X, [MangledName("n")] int N)
	{
		return Fixed_point_round_Fract.Invoke(X, N);
	}
}
