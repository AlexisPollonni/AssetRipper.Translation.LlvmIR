namespace LlvmLibC.GlobalFunctions;

internal static partial class llogbf128
{
	public static long Invoke(double x)
	{
		return fputil_intlogb_long_float128.Invoke(x);
	}
}
