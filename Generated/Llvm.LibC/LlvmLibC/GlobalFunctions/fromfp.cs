namespace LlvmLibC.GlobalFunctions;

internal static partial class fromfp
{
	public static double Invoke(double x, int rnd, int width)
	{
		return fputil_fromfp_true_double.Invoke(x, rnd, width);
	}
}
