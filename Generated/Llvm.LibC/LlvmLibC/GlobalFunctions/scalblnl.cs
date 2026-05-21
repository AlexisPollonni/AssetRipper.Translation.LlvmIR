namespace LlvmLibC.GlobalFunctions;

internal static partial class scalblnl
{
	public static double Invoke(double x, long n)
	{
		return fputil_ldexp_long_double_long.Invoke(x, n);
	}
}
