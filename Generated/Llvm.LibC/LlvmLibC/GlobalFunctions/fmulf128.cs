namespace LlvmLibC.GlobalFunctions;

internal static partial class fmulf128
{
	public static float Invoke(double x, double y)
	{
		return generic_mul_float_float128.Invoke(x, y);
	}
}
