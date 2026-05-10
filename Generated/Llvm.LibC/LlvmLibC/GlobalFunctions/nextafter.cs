namespace LlvmLibC.GlobalFunctions;

internal static partial class nextafter
{
	public static double Invoke(double x, double y)
	{
		return double_fputil_nextafter_double_double_0_double_double.Invoke(x, y);
	}
}
