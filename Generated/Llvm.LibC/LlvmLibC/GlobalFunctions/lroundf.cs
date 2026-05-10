namespace LlvmLibC.GlobalFunctions;

internal static partial class lroundf
{
	public static long Invoke(float x)
	{
		return long_fputil_round_to_signed_integer_float_long_0_float.Invoke(x);
	}
}
