namespace LlvmLibC.GlobalFunctions;

internal static partial class lroundf
{
	public static long Invoke(float x)
	{
		return fputil_round_to_signed_integer_float_long_0.Invoke(x);
	}
}
