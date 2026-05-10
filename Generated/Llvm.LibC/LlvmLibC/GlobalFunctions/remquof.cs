namespace LlvmLibC.GlobalFunctions;

internal static partial class remquof
{
	public unsafe static float Invoke(float x, float y, void* exp)
	{
		return float_fputil_remquo_float_0_float_float_int.Invoke(x, y, exp);
	}
}
