namespace LlvmLibC.GlobalFunctions;

internal static partial class fmaf
{
	public static float Invoke(float x, float y, float z)
	{
		return fputil_fma_float_float.Invoke(x, y, z);
	}
}
