namespace LlvmLibC.GlobalFunctions;

internal static partial class llround
{
	public static long Invoke(double x)
	{
		return fputil_round_to_signed_integer_double_long_long_0.Invoke(x);
	}
}
