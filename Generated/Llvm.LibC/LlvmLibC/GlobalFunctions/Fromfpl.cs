using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Fromfpl
{
	[MangledName("fromfpl")]
	[DemangledName("fromfpl")]
	public static double Invoke([MangledName("x")] double X, [MangledName("rnd")] int Rnd, [MangledName("width")] int Width)
	{
		return Fputil_fromfp_true_long_double.Invoke(X, Rnd, Width);
	}
}
