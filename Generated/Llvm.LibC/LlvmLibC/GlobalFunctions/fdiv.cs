namespace LlvmLibC.GlobalFunctions;

internal static partial class fdiv
{
	public static float Invoke(double x, double y)
	{
		return generic_div_float_double.Invoke(x, y);
	}
}
