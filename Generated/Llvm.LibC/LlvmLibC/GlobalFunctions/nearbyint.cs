namespace LlvmLibC.GlobalFunctions;

internal static partial class nearbyint
{
	public static double Invoke(double x)
	{
		return fputil_round_using_current_rounding_mode_double.Invoke(x);
	}
}
