namespace LlvmLibC.GlobalFunctions;

internal static partial class ceill
{
	public static double Invoke(double x)
	{
		return fputil_ceil_long_double_0.Invoke(x);
	}
}
