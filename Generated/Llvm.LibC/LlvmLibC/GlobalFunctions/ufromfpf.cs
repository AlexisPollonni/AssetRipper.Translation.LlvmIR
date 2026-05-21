namespace LlvmLibC.GlobalFunctions;

internal static partial class ufromfpf
{
	public static float Invoke(float x, int rnd, int width)
	{
		return fputil_fromfp_false_float.Invoke(x, rnd, width);
	}
}
