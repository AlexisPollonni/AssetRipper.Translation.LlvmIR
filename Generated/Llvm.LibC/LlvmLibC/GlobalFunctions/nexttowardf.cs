namespace LlvmLibC.GlobalFunctions;

internal static partial class nexttowardf
{
	public static float Invoke(float x, double y)
	{
		return float_fputil_nextafter_float_long_double_0_float_long_double.Invoke(x, y);
	}
}
