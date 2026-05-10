namespace LlvmLibC.GlobalFunctions;

internal static partial class ffmal
{
	public static float Invoke(double x, double y, double z)
	{
		return float_fputil_fma_float_long_double_long_double_long_double_long_double.Invoke(x, y, z);
	}
}
