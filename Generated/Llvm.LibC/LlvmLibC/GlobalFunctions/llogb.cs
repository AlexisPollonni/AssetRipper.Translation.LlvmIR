namespace LlvmLibC.GlobalFunctions;

internal static partial class llogb
{
	public static long Invoke(double x)
	{
		return fputil_intlogb_long_double.Invoke(x);
	}
}
