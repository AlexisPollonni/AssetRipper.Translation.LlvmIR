using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Dsqrtf128
{
	[MangledName("dsqrtf128")]
	[DemangledName("dsqrtf128")]
	public static double Invoke([MangledName("x")] double X)
	{
		return Fputil_sqrt_double_float128.Invoke(X);
	}
}
