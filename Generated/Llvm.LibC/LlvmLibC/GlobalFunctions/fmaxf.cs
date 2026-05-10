namespace LlvmLibC.GlobalFunctions;

internal static partial class fmaxf
{
	public static float Invoke(float x, float y)
	{
		return float_fputil_fmax_float_0_float_float.Invoke(x, y);
	}
}
