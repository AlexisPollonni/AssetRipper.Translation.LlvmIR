namespace LlvmLibC.GlobalFunctions;

internal static partial class llrintf128
{
	public static long Invoke(double x)
	{
		return long_long_fputil_round_to_signed_integer_using_current_rounding_mode_float128_long_long_0_float128.Invoke(x);
	}
}
