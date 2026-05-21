namespace LlvmLibC.GlobalFunctions;

internal static partial class roundf
{
	public static float Invoke(float x)
	{
		return fputil_round_float_0.Invoke(x);
	}
}
