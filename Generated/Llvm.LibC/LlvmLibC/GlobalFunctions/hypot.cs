namespace LlvmLibC.GlobalFunctions;

internal static partial class hypot
{
	public static double Invoke(double x, double y)
	{
		return double_fputil_hypot_double_0_double_double.Invoke(x, y);
	}
}
