namespace LlvmLibC.GlobalFunctions;

internal static partial class ldexpl
{
	public static double Invoke(double x, int exp)
	{
		return fputil_ldexp_long_double_int.Invoke(x, exp);
	}
}
