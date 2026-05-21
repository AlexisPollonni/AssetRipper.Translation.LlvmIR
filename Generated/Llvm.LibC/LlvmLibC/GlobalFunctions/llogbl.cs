namespace LlvmLibC.GlobalFunctions;

internal static partial class llogbl
{
	public static long Invoke(double x)
	{
		return fputil_intlogb_long_long_double.Invoke(x);
	}
}
