namespace LlvmLibC.GlobalFunctions;

internal static partial class lroundl
{
	public static long Invoke(double x)
	{
		return long_fputil_round_to_signed_integer_long_double_long_0_long_double.Invoke(x);
	}
}
