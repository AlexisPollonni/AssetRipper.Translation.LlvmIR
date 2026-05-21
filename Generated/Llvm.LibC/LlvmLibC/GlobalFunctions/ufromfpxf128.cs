namespace LlvmLibC.GlobalFunctions;

internal static partial class ufromfpxf128
{
	public static double Invoke(double x, int rnd, int width)
	{
		return fputil_fromfpx_false_float128.Invoke(x, rnd, width);
	}
}
