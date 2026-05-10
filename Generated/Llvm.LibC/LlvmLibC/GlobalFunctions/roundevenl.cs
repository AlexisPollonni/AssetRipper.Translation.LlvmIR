namespace LlvmLibC.GlobalFunctions;

internal static partial class roundevenl
{
	public static double Invoke(double x)
	{
		return cpp_enable_if_cpp_is_floating_point_v_long_double_long_double_type_fputil_round_using_specific_rounding_mode_long_double_long_double_int.Invoke(x, 4);
	}
}
