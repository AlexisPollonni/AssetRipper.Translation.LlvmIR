namespace LlvmLibC.GlobalFunctions;

internal static partial class ddivf128
{
	public static double Invoke(double x, double y)
	{
		return generic_div_double_float128.Invoke(x, y);
	}
}
