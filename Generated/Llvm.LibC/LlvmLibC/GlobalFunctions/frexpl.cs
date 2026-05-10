namespace LlvmLibC.GlobalFunctions;

internal static partial class frexpl
{
	public unsafe static double Invoke(double x, void* exp)
	{
		return long_double_fputil_frexp_long_double_0_long_double_int.Invoke(x, exp);
	}
}
