namespace LlvmLibC.GlobalFunctions;

internal static partial class faddl
{
	public static float Invoke(double x, double y)
	{
		return generic_add_float_long_double.Invoke(x, y);
	}
}
