namespace LlvmLibC.GlobalFunctions;

internal static partial class ceill
{
	public static double Invoke(double x)
	{
		return long_double_fputil_ceil_long_double_0_long_double.Invoke(x);
	}
}
