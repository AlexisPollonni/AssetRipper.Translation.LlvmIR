namespace LlvmLibC.GlobalFunctions;

internal static partial class roundf128
{
	public static double Invoke(double x)
	{
		return float128_fputil_round_float128_0_float128.Invoke(x);
	}
}
