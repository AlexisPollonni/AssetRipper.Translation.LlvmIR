using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Ufromfpf128
{
	[MangledName("ufromfpf128")]
	[DemangledName("ufromfpf128")]
	public static double Invoke([MangledName("x")] double X, [MangledName("rnd")] int Rnd, [MangledName("width")] int Width)
	{
		return Fputil_fromfp_false_float128.Invoke(X, Rnd, Width);
	}
}
