namespace LlvmLibC.GlobalFunctions;

internal static partial class rintl
{
	public static double Invoke(double x)
	{
		return cpp_enable_if_cpp_is_floating_point_v_long_double_long_double_type_fputil_round_using_current_rounding_mode_long_double_long_double.Invoke(x);
	}
}
