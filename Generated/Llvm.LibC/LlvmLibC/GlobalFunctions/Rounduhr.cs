using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Rounduhr
{
	[MangledName("rounduhr")]
	[DemangledName("rounduhr")]
	public static sbyte Invoke([MangledName("x")] sbyte X, [MangledName("n")] int N)
	{
		return Fixed_point_round_unsigned_short_Fract.Invoke(X, N);
	}
}
