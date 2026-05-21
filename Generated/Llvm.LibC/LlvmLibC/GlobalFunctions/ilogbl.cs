namespace LlvmLibC.GlobalFunctions;

internal static partial class ilogbl
{
	public static int Invoke(double x)
	{
		return fputil_intlogb_int_long_double.Invoke(x);
	}
}
