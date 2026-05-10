namespace LlvmLibC.GlobalFunctions;

internal static partial class sqrtf128
{
	public static double Invoke(double x)
	{
		return cpp_enable_if_cpp_is_floating_point_v_float128_cpp_is_floating_point_v_float128_sizeof_float128_sizeof_float128_float128_type_fputil_sqrt_float128_float128_float128.Invoke(x);
	}
}
