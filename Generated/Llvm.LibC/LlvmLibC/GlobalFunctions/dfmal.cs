namespace LlvmLibC.GlobalFunctions;

internal static partial class dfmal
{
	public static double Invoke(double x, double y, double z)
	{
		return double_fputil_fma_double_long_double_long_double_long_double_long_double.Invoke(x, y, z);
	}
}
