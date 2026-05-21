namespace LlvmLibC.GlobalFunctions;

internal static partial class frexp
{
	public unsafe static double Invoke(double x, void* exp)
	{
		return fputil_frexp_double_0.Invoke(x, exp);
	}
}
