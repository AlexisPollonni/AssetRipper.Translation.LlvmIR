namespace LlvmLibC.GlobalFunctions;

internal static partial class scalbnf128
{
	public static double Invoke(double x, int n)
	{
		return fputil_ldexp_float128_int.Invoke(x, n);
	}
}
