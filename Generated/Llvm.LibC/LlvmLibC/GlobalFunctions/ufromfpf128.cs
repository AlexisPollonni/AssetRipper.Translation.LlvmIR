namespace LlvmLibC.GlobalFunctions;

internal static partial class ufromfpf128
{
	public static double Invoke(double x, int rnd, int width)
	{
		return fputil_fromfp_false_float128.Invoke(x, rnd, width);
	}
}
