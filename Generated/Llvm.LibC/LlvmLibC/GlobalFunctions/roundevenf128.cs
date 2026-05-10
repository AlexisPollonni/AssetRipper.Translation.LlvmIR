namespace LlvmLibC.GlobalFunctions;

internal static partial class roundevenf128
{
	public static double Invoke(double x)
	{
		return cpp_enable_if_cpp_is_floating_point_v_float128_float128_type_fputil_round_using_specific_rounding_mode_float128_float128_int.Invoke(x, 4);
	}
}
