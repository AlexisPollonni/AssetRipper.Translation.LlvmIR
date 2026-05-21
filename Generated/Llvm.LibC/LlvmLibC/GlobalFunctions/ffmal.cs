namespace LlvmLibC.GlobalFunctions;

internal static partial class ffmal
{
	public static float Invoke(double x, double y, double z)
	{
		return fputil_fma_float_long_double.Invoke(x, y, z);
	}
}
