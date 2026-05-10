namespace LlvmLibC.GlobalFunctions;

internal static partial class modff128
{
	public unsafe static double Invoke(double x, void* iptr)
	{
		return float128_fputil_modf_float128_0_float128_float128.Invoke(x, iptr);
	}
}
