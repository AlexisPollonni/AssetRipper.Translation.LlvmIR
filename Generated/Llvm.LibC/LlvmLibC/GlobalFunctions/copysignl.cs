namespace LlvmLibC.GlobalFunctions;

internal static partial class copysignl
{
	public static double Invoke(double x, double y)
	{
		return long_double_fputil_copysign_long_double_0_long_double_long_double.Invoke(x, y);
	}
}
