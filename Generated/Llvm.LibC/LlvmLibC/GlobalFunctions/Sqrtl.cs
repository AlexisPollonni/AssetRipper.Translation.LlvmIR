using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Sqrtl
{
	[MangledName("sqrtl")]
	[DemangledName("sqrtl")]
	public static double Invoke([MangledName("x")] double X)
	{
		return Fputil_sqrt_long_double_long_double.Invoke(X);
	}
}
