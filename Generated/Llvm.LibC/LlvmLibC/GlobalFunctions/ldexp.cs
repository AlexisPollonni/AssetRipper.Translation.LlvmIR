namespace LlvmLibC.GlobalFunctions;

internal static partial class ldexp
{
	public static double Invoke(double x, int exp)
	{
		return fputil_ldexp_double_int.Invoke(x, exp);
	}
}
