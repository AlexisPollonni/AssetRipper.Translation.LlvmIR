namespace LlvmLibC.GlobalFunctions;

internal static partial class frexpf128
{
	public unsafe static double Invoke(double x, void* exp)
	{
		return float128_fputil_frexp_float128_0_float128_int.Invoke(x, exp);
	}
}
