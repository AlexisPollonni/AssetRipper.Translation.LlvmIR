namespace LlvmLibC.GlobalFunctions;

internal static partial class rint
{
	public static double Invoke(double x)
	{
		return cpp_enable_if_cpp_is_floating_point_v_double_double_type_fputil_round_using_current_rounding_mode_double_double.Invoke(x);
	}
}
