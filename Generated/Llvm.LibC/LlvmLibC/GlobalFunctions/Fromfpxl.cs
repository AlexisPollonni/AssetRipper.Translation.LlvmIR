using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Fromfpxl
{
	[MangledName("fromfpxl")]
	[DemangledName("fromfpxl")]
	public static double Invoke([MangledName("x")] double X, [MangledName("rnd")] int Rnd, [MangledName("width")] int Width)
	{
		return Fputil_fromfpx_true_long_double.Invoke(X, Rnd, Width);
	}
}
