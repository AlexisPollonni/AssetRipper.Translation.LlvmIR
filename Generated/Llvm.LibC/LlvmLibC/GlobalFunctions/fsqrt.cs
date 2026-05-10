namespace LlvmLibC.GlobalFunctions;

internal static partial class fsqrt
{
	public static float Invoke(double x)
	{
		return cpp_enable_if_cpp_is_floating_point_v_float_cpp_is_floating_point_v_double_sizeof_float_sizeof_double_float_type_fputil_sqrt_float_double_double.Invoke(x);
	}
}
