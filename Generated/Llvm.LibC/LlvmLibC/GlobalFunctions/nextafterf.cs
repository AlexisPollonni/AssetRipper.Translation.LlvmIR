namespace LlvmLibC.GlobalFunctions;

internal static partial class nextafterf
{
	public static float Invoke(float x, float y)
	{
		return fputil_nextafter_float_float_0.Invoke(x, y);
	}
}
