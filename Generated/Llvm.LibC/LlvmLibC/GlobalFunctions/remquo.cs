namespace LlvmLibC.GlobalFunctions;

internal static partial class remquo
{
	public unsafe static double Invoke(double x, double y, void* exp)
	{
		return fputil_remquo_double_0.Invoke(x, y, exp);
	}
}
