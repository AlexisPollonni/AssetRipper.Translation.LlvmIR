namespace LlvmLibC.GlobalFunctions;

internal static partial class nearbyintl
{
	public static double Invoke(double x)
	{
		return fputil_round_using_current_rounding_mode_long_double.Invoke(x);
	}
}
