namespace LlvmLibC.GlobalFunctions;

internal static partial class fsqrtl
{
	public static float Invoke(double x)
	{
		return fputil_sqrt_float_long_double.Invoke(x);
	}
}
