namespace LlvmLibC.GlobalFunctions;

internal static partial class lrintf
{
	public static long Invoke(float x)
	{
		return long_fputil_round_to_signed_integer_using_current_rounding_mode_float_long_0_float.Invoke(x);
	}
}
