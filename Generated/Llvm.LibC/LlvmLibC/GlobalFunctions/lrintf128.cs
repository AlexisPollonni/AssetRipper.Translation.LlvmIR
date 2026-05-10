namespace LlvmLibC.GlobalFunctions;

internal static partial class lrintf128
{
	public static long Invoke(double x)
	{
		return long_fputil_round_to_signed_integer_using_current_rounding_mode_float128_long_0_float128.Invoke(x);
	}
}
