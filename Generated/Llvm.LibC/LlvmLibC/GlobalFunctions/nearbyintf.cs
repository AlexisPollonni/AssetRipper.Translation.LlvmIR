namespace LlvmLibC.GlobalFunctions;

internal static partial class nearbyintf
{
	public static float Invoke(float x)
	{
		return cpp_enable_if_cpp_is_floating_point_v_float_float_type_fputil_round_using_current_rounding_mode_float_float.Invoke(x);
	}
}
