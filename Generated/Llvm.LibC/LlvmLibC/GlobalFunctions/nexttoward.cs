namespace LlvmLibC.GlobalFunctions;

internal static partial class nexttoward
{
	public static double Invoke(double x, double y)
	{
		return double_fputil_nextafter_double_long_double_0_double_long_double.Invoke(x, y);
	}
}
