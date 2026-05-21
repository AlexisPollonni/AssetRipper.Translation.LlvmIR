namespace LlvmLibC.GlobalFunctions;

internal static partial class frexpf128
{
	public unsafe static double Invoke(double x, void* exp)
	{
		return fputil_frexp_float128_0.Invoke(x, exp);
	}
}
