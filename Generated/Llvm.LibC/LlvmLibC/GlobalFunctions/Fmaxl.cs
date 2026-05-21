using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Fmaxl
{
	[MangledName("fmaxl")]
	[DemangledName("fmaxl")]
	public static double Invoke([MangledName("x")] double X, [MangledName("y")] double Y)
	{
		return Fputil_fmax_long_double_0.Invoke(X, Y);
	}
}
