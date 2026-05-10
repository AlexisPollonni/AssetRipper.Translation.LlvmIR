namespace LlvmLibC.GlobalFunctions;

internal static partial class ldexp
{
	public static double Invoke(double x, int exp)
	{
		return cpp_enable_if_cpp_is_floating_point_v_double_cpp_is_integral_v_int_double_type_fputil_ldexp_double_int_double_int.Invoke(x, exp);
	}
}
