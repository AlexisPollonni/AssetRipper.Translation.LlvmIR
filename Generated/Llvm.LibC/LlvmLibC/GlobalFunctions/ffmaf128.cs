namespace LlvmLibC.GlobalFunctions;

internal static partial class ffmaf128
{
	public static float Invoke(double x, double y, double z)
	{
		return fputil_fma_float_float128.Invoke(x, y, z);
	}
}
