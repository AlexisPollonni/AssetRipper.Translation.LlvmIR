using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Sqrtf128
{
	[MangledName("sqrtf128")]
	[DemangledName("sqrtf128")]
	public static double Invoke([MangledName("x")] double X)
	{
		return Fputil_sqrt_float128_float128.Invoke(X);
	}
}
