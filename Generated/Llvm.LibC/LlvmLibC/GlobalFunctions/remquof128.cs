namespace LlvmLibC.GlobalFunctions;

internal static partial class remquof128
{
	public unsafe static double Invoke(double x, double y, void* exp)
	{
		return float128_fputil_remquo_float128_0_float128_float128_int.Invoke(x, y, exp);
	}
}
