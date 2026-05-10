namespace LlvmLibC.GlobalFunctions;

internal static partial class ceilf128
{
	public static double Invoke(double x)
	{
		return float128_fputil_ceil_float128_0_float128.Invoke(x);
	}
}
