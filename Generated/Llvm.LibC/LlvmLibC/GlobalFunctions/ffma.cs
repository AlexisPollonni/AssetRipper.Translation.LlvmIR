namespace LlvmLibC.GlobalFunctions;

internal static partial class ffma
{
	public static float Invoke(double x, double y, double z)
	{
		return fputil_fma_float_double.Invoke(x, y, z);
	}
}
