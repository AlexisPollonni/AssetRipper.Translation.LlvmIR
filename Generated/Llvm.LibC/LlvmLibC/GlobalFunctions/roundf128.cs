namespace LlvmLibC.GlobalFunctions;

internal static partial class roundf128
{
	public static double Invoke(double x)
	{
		return fputil_round_float128_0.Invoke(x);
	}
}
