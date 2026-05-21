namespace LlvmLibC.GlobalFunctions;

internal static partial class roundeven
{
	public static double Invoke(double x)
	{
		return fputil_round_using_specific_rounding_mode_double.Invoke(x, 4);
	}
}
