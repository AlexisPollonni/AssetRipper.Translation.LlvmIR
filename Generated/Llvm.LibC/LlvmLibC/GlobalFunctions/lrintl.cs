namespace LlvmLibC.GlobalFunctions;

internal static partial class lrintl
{
	public static long Invoke(double x)
	{
		return long_fputil_round_to_signed_integer_using_current_rounding_mode_long_double_long_0_long_double.Invoke(x);
	}
}
