using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Ufromfpxf
{
	[MangledName("ufromfpxf")]
	[DemangledName("ufromfpxf")]
	public static float Invoke([MangledName("x")] float X, [MangledName("rnd")] int Rnd, [MangledName("width")] int Width)
	{
		return Fputil_fromfpx_false_float.Invoke(X, Rnd, Width);
	}
}
