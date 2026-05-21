namespace LlvmLibC.GlobalFunctions;

internal static partial class fromfpf
{
	public static float Invoke(float x, int rnd, int width)
	{
		return fputil_fromfp_true_float.Invoke(x, rnd, width);
	}
}
