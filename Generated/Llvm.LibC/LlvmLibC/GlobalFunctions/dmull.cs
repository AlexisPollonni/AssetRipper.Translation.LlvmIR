namespace LlvmLibC.GlobalFunctions;

internal static partial class dmull
{
	public static double Invoke(double x, double y)
	{
		return generic_mul_double_long_double.Invoke(x, y);
	}
}
