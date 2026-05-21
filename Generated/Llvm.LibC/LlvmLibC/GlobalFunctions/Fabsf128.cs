using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Fabsf128
{
	[MangledName("fabsf128")]
	[DemangledName("fabsf128")]
	public static double Invoke([MangledName("x")] double X)
	{
		return Fputil_abs_float128_0.Invoke(X);
	}
}
