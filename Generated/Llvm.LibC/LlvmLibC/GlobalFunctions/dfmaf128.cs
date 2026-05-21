namespace LlvmLibC.GlobalFunctions;

internal static partial class dfmaf128
{
	public static double Invoke(double x, double y, double z)
	{
		return fputil_fma_double_float128.Invoke(x, y, z);
	}
}
