using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Ufromfpxf128
{
	[MangledName("ufromfpxf128")]
	[DemangledName("ufromfpxf128")]
	public static double Invoke([MangledName("x")] double X, [MangledName("rnd")] int Rnd, [MangledName("width")] int Width)
	{
		return Fputil_fromfpx_false_float128.Invoke(X, Rnd, Width);
	}
}
