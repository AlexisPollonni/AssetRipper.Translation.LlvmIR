namespace LlvmLibC.GlobalFunctions;

internal static partial class floorf128
{
	public static double Invoke(double x)
	{
		return fputil_floor_float128_0.Invoke(x);
	}
}
