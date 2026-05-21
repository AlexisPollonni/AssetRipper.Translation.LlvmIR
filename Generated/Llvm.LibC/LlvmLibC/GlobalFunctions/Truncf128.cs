using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Truncf128
{
	[MangledName("truncf128")]
	[DemangledName("truncf128")]
	public static double Invoke([MangledName("x")] double X)
	{
		return Fputil_trunc_float128_0.Invoke(X);
	}
}
