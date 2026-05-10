namespace LlvmLibC.GlobalFunctions;

internal static partial class roundl
{
	public static double Invoke(double x)
	{
		return long_double_fputil_round_long_double_0_long_double.Invoke(x);
	}
}
