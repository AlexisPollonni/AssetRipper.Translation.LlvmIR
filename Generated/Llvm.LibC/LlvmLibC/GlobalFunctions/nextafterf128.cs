namespace LlvmLibC.GlobalFunctions;

internal static partial class nextafterf128
{
	public static double Invoke(double x, double y)
	{
		return fputil_nextafter_float128_float128_0.Invoke(x, y);
	}
}
