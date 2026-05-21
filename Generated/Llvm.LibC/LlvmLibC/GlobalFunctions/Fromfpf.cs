using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Fromfpf
{
	[MangledName("fromfpf")]
	[DemangledName("fromfpf")]
	public static float Invoke([MangledName("x")] float X, [MangledName("rnd")] int Rnd, [MangledName("width")] int Width)
	{
		return Fputil_fromfp_true_float.Invoke(X, Rnd, Width);
	}
}
