namespace LlvmLibC.GlobalFunctions;

internal static partial class sqrtf128
{
	public static double Invoke(double x)
	{
		return fputil_sqrt_float128_float128.Invoke(x);
	}
}
