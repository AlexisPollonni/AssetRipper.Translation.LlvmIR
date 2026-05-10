namespace LlvmLibC.GlobalFunctions;

internal static partial class lround
{
	public static long Invoke(double x)
	{
		return long_fputil_round_to_signed_integer_double_long_0_double.Invoke(x);
	}
}
