using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Ufromfpx
{
	[MangledName("ufromfpx")]
	[DemangledName("ufromfpx")]
	public static double Invoke([MangledName("x")] double X, [MangledName("rnd")] int Rnd, [MangledName("width")] int Width)
	{
		return Fputil_fromfpx_false_double.Invoke(X, Rnd, Width);
	}
}
