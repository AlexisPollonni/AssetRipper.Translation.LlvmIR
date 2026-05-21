namespace LlvmLibC.GlobalFunctions;

internal static partial class remquof128
{
	public unsafe static double Invoke(double x, double y, void* exp)
	{
		return fputil_remquo_float128_0.Invoke(x, y, exp);
	}
}
