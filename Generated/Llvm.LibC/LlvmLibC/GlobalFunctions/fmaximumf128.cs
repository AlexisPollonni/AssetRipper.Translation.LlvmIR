namespace LlvmLibC.GlobalFunctions;

internal static partial class fmaximumf128
{
	public static double Invoke(double x, double y)
	{
		return float128_fputil_fmaximum_float128_0_float128_float128.Invoke(x, y);
	}
}
