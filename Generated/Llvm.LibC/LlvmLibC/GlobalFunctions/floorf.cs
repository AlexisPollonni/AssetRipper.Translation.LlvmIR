namespace LlvmLibC.GlobalFunctions;

internal static partial class floorf
{
	public static float Invoke(float x)
	{
		return float_fputil_floor_float_0_float.Invoke(x);
	}
}
