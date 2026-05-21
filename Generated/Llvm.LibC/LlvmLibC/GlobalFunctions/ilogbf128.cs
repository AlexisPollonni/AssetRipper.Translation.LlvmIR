namespace LlvmLibC.GlobalFunctions;

internal static partial class ilogbf128
{
	public static int Invoke(double x)
	{
		return fputil_intlogb_int_float128.Invoke(x);
	}
}
