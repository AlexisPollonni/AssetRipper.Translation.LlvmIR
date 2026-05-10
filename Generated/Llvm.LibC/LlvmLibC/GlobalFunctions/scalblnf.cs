namespace LlvmLibC.GlobalFunctions;

internal static partial class scalblnf
{
	public static float Invoke(float x, long n)
	{
		return cpp_enable_if_cpp_is_floating_point_v_float_cpp_is_integral_v_long_float_type_fputil_ldexp_float_long_float_long.Invoke(x, n);
	}
}
