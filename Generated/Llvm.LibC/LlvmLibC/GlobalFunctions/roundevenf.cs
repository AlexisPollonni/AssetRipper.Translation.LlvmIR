namespace LlvmLibC.GlobalFunctions;

internal static partial class roundevenf
{
	public static float Invoke(float x)
	{
		return cpp_enable_if_cpp_is_floating_point_v_float_float_type_fputil_round_using_specific_rounding_mode_float_float_int.Invoke(x, 4);
	}
}
