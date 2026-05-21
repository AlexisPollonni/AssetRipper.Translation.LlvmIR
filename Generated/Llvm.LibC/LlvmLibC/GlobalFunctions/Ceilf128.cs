using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Ceilf128
{
	[MangledName("ceilf128")]
	[DemangledName("ceilf128")]
	public static double Invoke([MangledName("x")] double X)
	{
		return Fputil_ceil_float128_0.Invoke(X);
	}
}
