namespace LlvmLibC.GlobalFunctions;

internal static partial class faddf128
{
	public static float Invoke(double x, double y)
	{
		return generic_add_float_float128.Invoke(x, y);
	}
}
