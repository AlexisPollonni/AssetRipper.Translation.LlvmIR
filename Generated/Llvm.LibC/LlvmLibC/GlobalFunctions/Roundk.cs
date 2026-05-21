using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Roundk
{
	[MangledName("roundk")]
	[DemangledName("roundk")]
	public static int Invoke([MangledName("x")] int X, [MangledName("n")] int N)
	{
		return Fixed_point_round_Accum.Invoke(X, N);
	}
}
