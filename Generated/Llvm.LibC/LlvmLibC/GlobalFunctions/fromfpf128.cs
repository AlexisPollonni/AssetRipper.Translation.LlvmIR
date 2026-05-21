namespace LlvmLibC.GlobalFunctions;

internal static partial class fromfpf128
{
	public static double Invoke(double x, int rnd, int width)
	{
		return fputil_fromfp_true_float128.Invoke(x, rnd, width);
	}
}
