namespace LlvmLibC.GlobalFunctions;

internal static partial class fsqrtf128
{
	public static float Invoke(double x)
	{
		return fputil_sqrt_float_float128.Invoke(x);
	}
}
