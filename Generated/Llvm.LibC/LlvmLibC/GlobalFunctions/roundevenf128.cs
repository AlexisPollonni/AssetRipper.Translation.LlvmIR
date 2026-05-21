namespace LlvmLibC.GlobalFunctions;

internal static partial class roundevenf128
{
	public static double Invoke(double x)
	{
		return fputil_round_using_specific_rounding_mode_float128.Invoke(x, 4);
	}
}
