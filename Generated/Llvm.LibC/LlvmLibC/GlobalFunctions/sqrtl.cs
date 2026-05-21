namespace LlvmLibC.GlobalFunctions;

internal static partial class sqrtl
{
	public static double Invoke(double x)
	{
		return fputil_sqrt_long_double_long_double.Invoke(x);
	}
}
