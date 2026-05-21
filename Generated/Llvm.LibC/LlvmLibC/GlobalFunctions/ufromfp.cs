namespace LlvmLibC.GlobalFunctions;

internal static partial class ufromfp
{
	public static double Invoke(double x, int rnd, int width)
	{
		return fputil_fromfp_false_double.Invoke(x, rnd, width);
	}
}
