namespace LlvmLibC.GlobalFunctions;

internal static partial class ilogb
{
	public static int Invoke(double x)
	{
		return fputil_intlogb_int_double.Invoke(x);
	}
}
