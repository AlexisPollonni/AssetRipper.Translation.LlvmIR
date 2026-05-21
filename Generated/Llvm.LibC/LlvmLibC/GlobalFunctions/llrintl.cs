namespace LlvmLibC.GlobalFunctions;

internal static partial class llrintl
{
	public static long Invoke(double x)
	{
		return fputil_round_to_signed_integer_using_current_rounding_mode_long_double_long_long_0.Invoke(x);
	}
}
