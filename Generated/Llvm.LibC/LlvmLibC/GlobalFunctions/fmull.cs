namespace LlvmLibC.GlobalFunctions;

internal static partial class fmull
{
	public static float Invoke(double x, double y)
	{
		return generic_mul_float_long_double.Invoke(x, y);
	}
}
