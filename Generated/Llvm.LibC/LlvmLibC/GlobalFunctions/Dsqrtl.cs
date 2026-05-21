using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Dsqrtl
{
	[MangledName("dsqrtl")]
	[DemangledName("dsqrtl")]
	public static double Invoke([MangledName("x")] double X)
	{
		return Fputil_sqrt_double_long_double.Invoke(X);
	}
}
