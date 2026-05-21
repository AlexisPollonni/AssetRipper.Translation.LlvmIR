using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Fdimf128
{
	[MangledName("fdimf128")]
	[DemangledName("fdimf128")]
	public static double Invoke([MangledName("x")] double X, [MangledName("y")] double Y)
	{
		return Fputil_fdim_float128_0.Invoke(X, Y);
	}
}
