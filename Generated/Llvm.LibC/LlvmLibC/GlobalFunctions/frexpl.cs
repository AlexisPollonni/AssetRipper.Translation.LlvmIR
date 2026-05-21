namespace LlvmLibC.GlobalFunctions;

internal static partial class frexpl
{
	public unsafe static double Invoke(double x, void* exp)
	{
		return fputil_frexp_long_double_0.Invoke(x, exp);
	}
}
