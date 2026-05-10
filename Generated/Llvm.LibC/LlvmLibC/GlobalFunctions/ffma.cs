namespace LlvmLibC.GlobalFunctions;

internal static partial class ffma
{
	public static float Invoke(double x, double y, double z)
	{
		return float_fputil_fma_float_double_double_double_double.Invoke(x, y, z);
	}
}
