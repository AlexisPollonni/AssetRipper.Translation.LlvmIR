namespace LlvmLibC.GlobalFunctions;

internal static partial class logb
{
	public static double Invoke(double x)
	{
		return double_fputil_logb_double_0_double.Invoke(x);
	}
}
