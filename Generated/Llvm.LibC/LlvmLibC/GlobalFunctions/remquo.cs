namespace LlvmLibC.GlobalFunctions;

internal static partial class remquo
{
	public unsafe static double Invoke(double x, double y, void* exp)
	{
		return double_fputil_remquo_double_0_double_double_int.Invoke(x, y, exp);
	}
}
