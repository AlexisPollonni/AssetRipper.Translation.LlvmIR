namespace LlvmLibC.GlobalFunctions;

internal static partial class fromfpl
{
	public static double Invoke(double x, int rnd, int width)
	{
		return fputil_fromfp_true_long_double.Invoke(x, rnd, width);
	}
}
