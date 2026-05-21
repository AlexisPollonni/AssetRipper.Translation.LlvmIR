using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Ufromfpf
{
	[MangledName("ufromfpf")]
	[DemangledName("ufromfpf")]
	public static float Invoke([MangledName("x")] float X, [MangledName("rnd")] int Rnd, [MangledName("width")] int Width)
	{
		return Fputil_fromfp_false_float.Invoke(X, Rnd, Width);
	}
}
