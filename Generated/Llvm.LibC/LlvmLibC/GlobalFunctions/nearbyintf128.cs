namespace LlvmLibC.GlobalFunctions;

internal static partial class nearbyintf128
{
	public static double Invoke(double x)
	{
		return cpp_enable_if_cpp_is_floating_point_v_float128_float128_type_fputil_round_using_current_rounding_mode_float128_float128.Invoke(x);
	}
}
