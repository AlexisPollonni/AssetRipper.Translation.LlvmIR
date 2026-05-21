using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Fromfpx
{
	[MangledName("fromfpx")]
	[DemangledName("fromfpx")]
	public static double Invoke([MangledName("x")] double X, [MangledName("rnd")] int Rnd, [MangledName("width")] int Width)
	{
		return Fputil_fromfpx_true_double.Invoke(X, Rnd, Width);
	}
}
