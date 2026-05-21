namespace LlvmLibC.GlobalFunctions;

internal static partial class fdivl
{
	public static float Invoke(double x, double y)
	{
		return generic_div_float_long_double.Invoke(x, y);
	}
}
