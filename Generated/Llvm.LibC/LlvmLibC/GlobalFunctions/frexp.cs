namespace LlvmLibC.GlobalFunctions;

internal static partial class frexp
{
	public unsafe static double Invoke(double x, void* exp)
	{
		return double_fputil_frexp_double_0_double_int.Invoke(x, exp);
	}
}
