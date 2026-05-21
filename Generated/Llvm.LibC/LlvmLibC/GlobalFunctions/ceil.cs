namespace LlvmLibC.GlobalFunctions;

internal static partial class ceil
{
	public static double Invoke(double x)
	{
		return fputil_ceil_double_0.Invoke(x);
	}
}
