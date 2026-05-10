namespace LlvmLibC.GlobalFunctions;

internal static partial class nextafterf
{
	public static float Invoke(float x, float y)
	{
		return float_fputil_nextafter_float_float_0_float_float.Invoke(x, y);
	}
}
