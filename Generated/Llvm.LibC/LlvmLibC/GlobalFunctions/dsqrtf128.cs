namespace LlvmLibC.GlobalFunctions;

internal static partial class dsqrtf128
{
	public static double Invoke(double x)
	{
		return fputil_sqrt_double_float128.Invoke(x);
	}
}
