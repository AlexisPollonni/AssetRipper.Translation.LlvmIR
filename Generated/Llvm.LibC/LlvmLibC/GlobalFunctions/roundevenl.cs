namespace LlvmLibC.GlobalFunctions;

internal static partial class roundevenl
{
	public static double Invoke(double x)
	{
		return fputil_round_using_specific_rounding_mode_long_double.Invoke(x, 4);
	}
}
