namespace LlvmLibC.GlobalFunctions;

internal static partial class logbf128
{
	public static double Invoke(double x)
	{
		return float128_fputil_logb_float128_0_float128.Invoke(x);
	}
}
