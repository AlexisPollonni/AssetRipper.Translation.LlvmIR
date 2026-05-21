namespace LlvmLibC.GlobalFunctions;

internal static partial class fabsf128
{
	public static double Invoke(double x)
	{
		return fputil_abs_float128_0.Invoke(x);
	}
}
