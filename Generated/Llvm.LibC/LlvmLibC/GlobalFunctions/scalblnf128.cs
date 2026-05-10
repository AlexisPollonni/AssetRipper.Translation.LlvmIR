namespace LlvmLibC.GlobalFunctions;

internal static partial class scalblnf128
{
	public static double Invoke(double x, long n)
	{
		return cpp_enable_if_cpp_is_floating_point_v_float128_cpp_is_integral_v_long_float128_type_fputil_ldexp_float128_long_float128_long.Invoke(x, n);
	}
}
