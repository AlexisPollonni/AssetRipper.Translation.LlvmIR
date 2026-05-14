namespace LlvmLibC.GlobalFunctions;

internal static partial class round
{
	public static double Invoke(double x)
	{
		return double_fputil_round_double_0_double.Invoke(x);
	}
}
