namespace LlvmLibC.GlobalFunctions;

internal static partial class dmulf128
{
	public static double Invoke(double x, double y)
	{
		return generic_mul_double_float128.Invoke(x, y);
	}
}
