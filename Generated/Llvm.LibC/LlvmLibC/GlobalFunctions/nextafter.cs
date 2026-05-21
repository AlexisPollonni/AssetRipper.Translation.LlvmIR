namespace LlvmLibC.GlobalFunctions;

internal static partial class nextafter
{
	public static double Invoke(double x, double y)
	{
		return fputil_nextafter_double_double_0.Invoke(x, y);
	}
}
