namespace LlvmLibC.GlobalFunctions;

internal static partial class ceilf128
{
	public static double Invoke(double x)
	{
		return fputil_ceil_float128_0.Invoke(x);
	}
}
