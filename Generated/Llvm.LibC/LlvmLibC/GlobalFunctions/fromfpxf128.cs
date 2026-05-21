namespace LlvmLibC.GlobalFunctions;

internal static partial class fromfpxf128
{
	public static double Invoke(double x, int rnd, int width)
	{
		return fputil_fromfpx_true_float128.Invoke(x, rnd, width);
	}
}
