namespace LlvmLibC.GlobalFunctions;

internal static partial class fabsl
{
	public static double Invoke(double x)
	{
		return long_double_fputil_abs_long_double_0_long_double.Invoke(x);
	}
}
