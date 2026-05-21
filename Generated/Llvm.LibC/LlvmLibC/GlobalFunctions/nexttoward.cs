namespace LlvmLibC.GlobalFunctions;

internal static partial class nexttoward
{
	public static double Invoke(double x, double y)
	{
		return fputil_nextafter_double_long_double_0.Invoke(x, y);
	}
}
