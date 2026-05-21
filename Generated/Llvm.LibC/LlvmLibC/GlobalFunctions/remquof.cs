namespace LlvmLibC.GlobalFunctions;

internal static partial class remquof
{
	public unsafe static float Invoke(float x, float y, void* exp)
	{
		return fputil_remquo_float_0.Invoke(x, y, exp);
	}
}
