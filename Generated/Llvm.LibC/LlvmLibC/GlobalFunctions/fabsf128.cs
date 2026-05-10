namespace LlvmLibC.GlobalFunctions;

internal static partial class fabsf128
{
	public static double Invoke(double x)
	{
		return float128_fputil_abs_float128_0_float128.Invoke(x);
	}
}
