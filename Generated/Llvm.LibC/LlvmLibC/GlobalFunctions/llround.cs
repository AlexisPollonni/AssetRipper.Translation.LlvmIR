namespace LlvmLibC.GlobalFunctions;

internal static partial class llround
{
	public static long Invoke(double x)
	{
		return long_long_fputil_round_to_signed_integer_double_long_long_0_double.Invoke(x);
	}
}
