namespace LlvmLibC.GlobalFunctions;

internal static partial class nearbyintf
{
	public static float Invoke(float x)
	{
		return fputil_round_using_current_rounding_mode_float.Invoke(x);
	}
}
