namespace LlvmLibC.GlobalFunctions;

internal static partial class dfmaf128
{
	public static double Invoke(double x, double y, double z)
	{
		return double_fputil_fma_double_float128_float128_float128_float128.Invoke(x, y, z);
	}
}
