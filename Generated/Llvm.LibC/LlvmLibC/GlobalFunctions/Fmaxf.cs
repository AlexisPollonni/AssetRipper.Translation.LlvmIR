using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Fmaxf
{
	[MangledName("fmaxf")]
	[DemangledName("fmaxf")]
	public static float Invoke([MangledName("x")] float X, [MangledName("y")] float Y)
	{
		return Fputil_fmax_float_0.Invoke(X, Y);
	}
}
