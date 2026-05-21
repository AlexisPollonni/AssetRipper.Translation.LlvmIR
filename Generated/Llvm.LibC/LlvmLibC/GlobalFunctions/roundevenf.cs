namespace LlvmLibC.GlobalFunctions;

internal static partial class roundevenf
{
	public static float Invoke(float x)
	{
		return fputil_round_using_specific_rounding_mode_float.Invoke(x, 4);
	}
}
