namespace LlvmLibC.GlobalFunctions;

internal static partial class ldexpf128
{
	public static double Invoke(double x, int exp)
	{
		return cpp_enable_if_cpp_is_floating_point_v_float128_cpp_is_integral_v_int_float128_type_fputil_ldexp_float128_int_float128_int.Invoke(x, exp);
	}
}
