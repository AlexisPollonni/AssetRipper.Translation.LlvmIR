namespace LlvmLibC.GlobalFunctions;

internal static partial class dfmal
{
	public static double Invoke(double x, double y, double z)
	{
		return fputil_fma_double_long_double.Invoke(x, y, z);
	}
}
