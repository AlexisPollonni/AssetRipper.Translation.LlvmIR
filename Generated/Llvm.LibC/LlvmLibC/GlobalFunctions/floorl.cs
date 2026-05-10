namespace LlvmLibC.GlobalFunctions;

internal static partial class floorl
{
	public static double Invoke(double x)
	{
		return long_double_fputil_floor_long_double_0_long_double.Invoke(x);
	}
}
