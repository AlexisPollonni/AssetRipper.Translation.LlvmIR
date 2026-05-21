using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Roundur
{
	[MangledName("roundur")]
	[DemangledName("roundur")]
	public static short Invoke([MangledName("x")] short X, [MangledName("n")] int N)
	{
		return Fixed_point_round_unsigned_Fract.Invoke(X, N);
	}
}
