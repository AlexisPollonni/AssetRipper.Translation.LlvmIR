namespace LlvmLibC.GlobalFunctions;

internal static partial class ufromfpl
{
	public static double Invoke(double x, int rnd, int width)
	{
		return fputil_fromfp_false_long_double.Invoke(x, rnd, width);
	}
}
