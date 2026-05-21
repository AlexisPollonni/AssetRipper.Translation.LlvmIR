namespace LlvmLibC.GlobalFunctions;

internal static partial class round
{
	public static double Invoke(double x)
	{
		return fputil_round_double_0.Invoke(x);
	}
}
