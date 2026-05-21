namespace LlvmLibC.GlobalFunctions;

internal static partial class copysignf128
{
	public static double Invoke(double x, double y)
	{
		return fputil_copysign_float128_0.Invoke(x, y);
	}
}
