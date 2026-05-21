namespace LlvmLibC.GlobalFunctions;

internal static partial class floorf
{
	public static float Invoke(float x)
	{
		return fputil_floor_float_0.Invoke(x);
	}
}
