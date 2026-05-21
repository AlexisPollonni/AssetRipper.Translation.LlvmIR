namespace LlvmLibC.GlobalFunctions;

internal static partial class fmaxf128
{
	public static double Invoke(double x, double y)
	{
		return fputil_fmax_float128_0.Invoke(x, y);
	}
}
