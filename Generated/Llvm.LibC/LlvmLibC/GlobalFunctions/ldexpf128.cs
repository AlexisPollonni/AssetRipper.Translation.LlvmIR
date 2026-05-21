namespace LlvmLibC.GlobalFunctions;

internal static partial class ldexpf128
{
	public static double Invoke(double x, int exp)
	{
		return fputil_ldexp_float128_int.Invoke(x, exp);
	}
}
