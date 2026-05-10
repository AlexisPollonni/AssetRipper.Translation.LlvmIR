namespace LlvmLibC.GlobalFunctions;

internal static partial class nextafterf128
{
	public static double Invoke(double x, double y)
	{
		return float128_fputil_nextafter_float128_float128_0_float128_float128.Invoke(x, y);
	}
}
