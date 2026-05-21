namespace LlvmLibC.GlobalFunctions;

internal static partial class nexttowardl
{
	public static double Invoke(double x, double y)
	{
		return fputil_nextafter.Invoke(x, y);
	}
}
