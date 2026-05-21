namespace LlvmLibC.GlobalFunctions;

internal static partial class fabsl
{
	public static double Invoke(double x)
	{
		return fputil_abs_long_double_0.Invoke(x);
	}
}
