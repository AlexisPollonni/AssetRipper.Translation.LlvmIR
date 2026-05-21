namespace LlvmLibC.GlobalFunctions;

internal static partial class remquol
{
	public unsafe static double Invoke(double x, double y, void* exp)
	{
		return fputil_remquo_long_double_0.Invoke(x, y, exp);
	}
}
