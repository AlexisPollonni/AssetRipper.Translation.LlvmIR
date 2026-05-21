using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Roundlr
{
	[MangledName("roundlr")]
	[DemangledName("roundlr")]
	public static int Invoke([MangledName("x")] int X, [MangledName("n")] int N)
	{
		return Fixed_point_round_long_Fract.Invoke(X, N);
	}
}
