namespace LlvmLibC.GlobalFunctions;

internal static partial class fma
{
	public static double Invoke(double x, double y, double z)
	{
		return double_fputil_fma_double_double_double_double_double.Invoke(x, y, z);
	}
}
