namespace LlvmLibC.GlobalFunctions;

internal static partial class modff128
{
	public unsafe static double Invoke(double x, void* iptr)
	{
		return fputil_modf_float128_0.Invoke(x, iptr);
	}
}
