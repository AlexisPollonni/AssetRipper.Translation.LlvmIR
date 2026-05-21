namespace LlvmLibC.GlobalFunctions;

internal static partial class llroundf
{
	public static long Invoke(float x)
	{
		return fputil_round_to_signed_integer_float_long_long_0.Invoke(x);
	}
}
