namespace LlvmLibC.GlobalFunctions;

internal static partial class lrint
{
	public static long Invoke(double x)
	{
		return long_fputil_round_to_signed_integer_using_current_rounding_mode_double_long_0_double.Invoke(x);
	}
}
