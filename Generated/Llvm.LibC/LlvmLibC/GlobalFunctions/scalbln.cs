namespace LlvmLibC.GlobalFunctions;

internal static partial class scalbln
{
	public static double Invoke(double x, long n)
	{
		return cpp_enable_if_cpp_is_floating_point_v_double_cpp_is_integral_v_long_double_type_fputil_ldexp_double_long_double_long.Invoke(x, n);
	}
}
