namespace LlvmLibC.GlobalFunctions;

internal static partial class sqrtf
{
	public static float Invoke(float x)
	{
		return fputil_sqrt_float_float.Invoke(x);
	}
}
