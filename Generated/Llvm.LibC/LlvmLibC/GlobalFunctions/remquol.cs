namespace LlvmLibC.GlobalFunctions;

internal static partial class remquol
{
	public unsafe static double Invoke(double x, double y, void* exp)
	{
		return long_double_fputil_remquo_long_double_0_long_double_long_double_int.Invoke(x, y, exp);
	}
}
