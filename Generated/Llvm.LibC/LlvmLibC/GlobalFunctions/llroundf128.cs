namespace LlvmLibC.GlobalFunctions;

internal static partial class llroundf128
{
	public static long Invoke(double x)
	{
		return fputil_round_to_signed_integer_float128_long_long_0.Invoke(x);
	}
}
