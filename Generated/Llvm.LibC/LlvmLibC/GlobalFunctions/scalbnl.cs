namespace LlvmLibC.GlobalFunctions;

internal static partial class scalbnl
{
	public static double Invoke(double x, int n)
	{
		return cpp_enable_if_cpp_is_floating_point_v_long_double_cpp_is_integral_v_int_long_double_type_fputil_ldexp_long_double_int_long_double_int.Invoke(x, n);
	}
}
