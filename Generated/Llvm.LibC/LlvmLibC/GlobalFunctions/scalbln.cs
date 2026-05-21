namespace LlvmLibC.GlobalFunctions;

internal static partial class scalbln
{
	public static double Invoke(double x, long n)
	{
		return fputil_ldexp_double_long.Invoke(x, n);
	}
}
