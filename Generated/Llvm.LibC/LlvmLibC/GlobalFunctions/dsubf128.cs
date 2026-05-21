namespace LlvmLibC.GlobalFunctions;

internal static partial class dsubf128
{
	public static double Invoke(double x, double y)
	{
		return generic_sub_double_float128.Invoke(x, y);
	}
}
