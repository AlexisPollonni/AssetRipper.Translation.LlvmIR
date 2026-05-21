namespace LlvmLibC.GlobalFunctions;

internal static partial class ddivl
{
	public static double Invoke(double x, double y)
	{
		return generic_div_double_long_double.Invoke(x, y);
	}
}
