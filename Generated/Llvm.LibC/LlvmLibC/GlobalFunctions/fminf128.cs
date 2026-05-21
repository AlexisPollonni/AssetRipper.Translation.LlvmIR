namespace LlvmLibC.GlobalFunctions;

internal static partial class fminf128
{
	public static double Invoke(double x, double y)
	{
		return fputil_fmin_float128_0.Invoke(x, y);
	}
}
