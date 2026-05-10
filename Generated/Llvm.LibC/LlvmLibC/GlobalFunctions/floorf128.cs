namespace LlvmLibC.GlobalFunctions;

internal static partial class floorf128
{
	public static double Invoke(double x)
	{
		return float128_fputil_floor_float128_0_float128.Invoke(x);
	}
}
