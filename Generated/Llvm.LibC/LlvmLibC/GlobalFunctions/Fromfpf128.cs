using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Fromfpf128
{
	[MangledName("fromfpf128")]
	[DemangledName("fromfpf128")]
	public static double Invoke([MangledName("x")] double X, [MangledName("rnd")] int Rnd, [MangledName("width")] int Width)
	{
		return Fputil_fromfp_true_float128.Invoke(X, Rnd, Width);
	}
}
