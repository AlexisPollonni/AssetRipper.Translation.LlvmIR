namespace LlvmLibC.GlobalFunctions;

internal static partial class lroundl
{
	public static long Invoke(double x)
	{
		return fputil_round_to_signed_integer_long_double_long_0.Invoke(x);
	}
}
