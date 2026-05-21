using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Rounduk
{
	[MangledName("rounduk")]
	[DemangledName("rounduk")]
	public static int Invoke([MangledName("x")] int X, [MangledName("n")] int N)
	{
		return Fixed_point_round_unsigned_Accum.Invoke(X, N);
	}
}
