using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Ufromfpl
{
	[MangledName("ufromfpl")]
	[DemangledName("ufromfpl")]
	public static double Invoke([MangledName("x")] double X, [MangledName("rnd")] int Rnd, [MangledName("width")] int Width)
	{
		return Fputil_fromfp_false_long_double.Invoke(X, Rnd, Width);
	}
}
