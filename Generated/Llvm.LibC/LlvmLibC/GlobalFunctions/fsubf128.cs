namespace LlvmLibC.GlobalFunctions;

internal static partial class fsubf128
{
	public static float Invoke(double x, double y)
	{
		return generic_sub_float_float128.Invoke(x, y);
	}
}
