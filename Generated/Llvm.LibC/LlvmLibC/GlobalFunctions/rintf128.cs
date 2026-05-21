namespace LlvmLibC.GlobalFunctions;

internal static partial class rintf128
{
	public static double Invoke(double x)
	{
		return fputil_round_using_current_rounding_mode_float128.Invoke(x);
	}
}
