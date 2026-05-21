using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Fmaxf128
{
	[MangledName("fmaxf128")]
	[DemangledName("fmaxf128")]
	public static double Invoke([MangledName("x")] double X, [MangledName("y")] double Y)
	{
		return Fputil_fmax_float128_0.Invoke(X, Y);
	}
}
