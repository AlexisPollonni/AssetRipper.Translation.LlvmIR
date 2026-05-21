namespace LlvmLibC.GlobalFunctions;

internal static partial class scalblnf128
{
	public static double Invoke(double x, long n)
	{
		return fputil_ldexp_float128_long.Invoke(x, n);
	}
}
