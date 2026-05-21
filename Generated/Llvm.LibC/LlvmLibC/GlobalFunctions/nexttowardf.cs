namespace LlvmLibC.GlobalFunctions;

internal static partial class nexttowardf
{
	public static float Invoke(float x, double y)
	{
		return fputil_nextafter_float_long_double_0.Invoke(x, y);
	}
}
