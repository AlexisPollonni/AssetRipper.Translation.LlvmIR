namespace LlvmLibC.GlobalFunctions;

internal static partial class fsqrt
{
	public static float Invoke(double x)
	{
		return fputil_sqrt_float_double.Invoke(x);
	}
}
