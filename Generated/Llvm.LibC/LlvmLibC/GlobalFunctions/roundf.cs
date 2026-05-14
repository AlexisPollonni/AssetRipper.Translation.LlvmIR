namespace LlvmLibC.GlobalFunctions;

internal static partial class roundf
{
	public static float Invoke(float x)
	{
		return float_fputil_round_float_0_float.Invoke(x);
	}
}
