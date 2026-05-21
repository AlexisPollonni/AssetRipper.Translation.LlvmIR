using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Fromfpxf128
{
	[MangledName("fromfpxf128")]
	[DemangledName("fromfpxf128")]
	public static double Invoke([MangledName("x")] double X, [MangledName("rnd")] int Rnd, [MangledName("width")] int Width)
	{
		return Fputil_fromfpx_true_float128.Invoke(X, Rnd, Width);
	}
}
