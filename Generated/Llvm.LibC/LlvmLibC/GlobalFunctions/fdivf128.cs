namespace LlvmLibC.GlobalFunctions;

internal static partial class fdivf128
{
	public static float Invoke(double x, double y)
	{
		return generic_div_float_float128.Invoke(x, y);
	}
}
