namespace LlvmLibC.GlobalFunctions;

internal static partial class copysignl
{
	public static double Invoke(double x, double y)
	{
		return fputil_copysign_long_double_0.Invoke(x, y);
	}
}
