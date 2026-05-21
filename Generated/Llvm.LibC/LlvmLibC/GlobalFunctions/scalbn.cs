namespace LlvmLibC.GlobalFunctions;

internal static partial class scalbn
{
	public static double Invoke(double x, int n)
	{
		return fputil_ldexp_double_int.Invoke(x, n);
	}
}
