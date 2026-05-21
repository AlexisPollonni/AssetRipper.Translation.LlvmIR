namespace LlvmLibC.GlobalFunctions;

internal static partial class llrintf
{
	public static long Invoke(float x)
	{
		return fputil_round_to_signed_integer_using_current_rounding_mode_float_long_long_0.Invoke(x);
	}
}
