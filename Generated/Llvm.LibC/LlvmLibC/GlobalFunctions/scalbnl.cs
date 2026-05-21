namespace LlvmLibC.GlobalFunctions;

internal static partial class scalbnl
{
	public static double Invoke(double x, int n)
	{
		return fputil_ldexp_long_double_int.Invoke(x, n);
	}
}
