namespace LlvmLibC.GlobalFunctions;

internal static partial class fsqrtf128
{
	public static float Invoke(double x)
	{
		return cpp_enable_if_cpp_is_floating_point_v_float_cpp_is_floating_point_v_float128_sizeof_float_sizeof_float128_float_type_fputil_sqrt_float_float128_float128.Invoke(x);
	}
}
