namespace LlvmLibC.GlobalFunctions;

internal static partial class floor
{
	public static double Invoke(double x)
	{
		return fputil_floor_double_0.Invoke(x);
	}
}
