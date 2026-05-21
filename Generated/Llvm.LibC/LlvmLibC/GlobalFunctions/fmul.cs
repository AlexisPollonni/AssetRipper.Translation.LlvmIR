namespace LlvmLibC.GlobalFunctions;

internal static partial class fmul
{
	public static float Invoke(double x, double y)
	{
		return generic_mul_float_double.Invoke(x, y);
	}
}
