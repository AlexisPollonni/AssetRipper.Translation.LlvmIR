namespace LlvmLibC.GlobalFunctions;

internal static partial class sqrt
{
	public static double Invoke(double x)
	{
		return fputil_sqrt_double_double.Invoke(x);
	}
}
