using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Roundulr
{
	[MangledName("roundulr")]
	[DemangledName("roundulr")]
	public static int Invoke([MangledName("x")] int X, [MangledName("n")] int N)
	{
		return Fixed_point_round_unsigned_long_Fract.Invoke(X, N);
	}
}
