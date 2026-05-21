using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Fromfpxf
{
	[MangledName("fromfpxf")]
	[DemangledName("fromfpxf")]
	public static float Invoke([MangledName("x")] float X, [MangledName("rnd")] int Rnd, [MangledName("width")] int Width)
	{
		return Fputil_fromfpx_true_float.Invoke(X, Rnd, Width);
	}
}
