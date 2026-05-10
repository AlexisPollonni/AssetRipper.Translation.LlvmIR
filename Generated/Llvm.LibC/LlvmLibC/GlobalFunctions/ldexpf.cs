namespace LlvmLibC.GlobalFunctions;

internal static partial class ldexpf
{
	public static float Invoke(float x, int exp)
	{
		return cpp_enable_if_cpp_is_floating_point_v_float_cpp_is_integral_v_int_float_type_fputil_ldexp_float_int_float_int.Invoke(x, exp);
	}
}
