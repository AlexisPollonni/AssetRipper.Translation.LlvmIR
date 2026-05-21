namespace LlvmLibC.GlobalFunctions;

internal static partial class dsqrtl
{
	public static double Invoke(double x)
	{
		return fputil_sqrt_double_long_double.Invoke(x);
	}
}
