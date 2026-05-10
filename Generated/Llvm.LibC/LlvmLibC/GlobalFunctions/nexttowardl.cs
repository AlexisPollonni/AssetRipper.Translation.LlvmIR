namespace LlvmLibC.GlobalFunctions;

internal static partial class nexttowardl
{
	public static double Invoke(double x, double y)
	{
		return fputil_nextafter_long_double_long_double.Invoke(x, y);
	}
}
