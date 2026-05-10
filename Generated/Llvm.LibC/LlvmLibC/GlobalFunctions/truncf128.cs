namespace LlvmLibC.GlobalFunctions;

internal static partial class truncf128
{
	public static double Invoke(double x)
	{
		return float128_fputil_trunc_float128_0_float128.Invoke(x);
	}
}
