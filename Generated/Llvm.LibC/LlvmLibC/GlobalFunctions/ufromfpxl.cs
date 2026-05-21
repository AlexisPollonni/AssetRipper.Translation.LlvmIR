namespace LlvmLibC.GlobalFunctions;

internal static partial class ufromfpxl
{
	public static double Invoke(double x, int rnd, int width)
	{
		return fputil_fromfpx_false_long_double.Invoke(x, rnd, width);
	}
}
