namespace LlvmLibC.GlobalFunctions;

internal static partial class fdiv
{
	public static float Invoke(double x, double y)
	{
		return cpp_enable_if_cpp_is_floating_point_v_float_cpp_is_floating_point_v_double_sizeof_float_sizeof_double_float_type_fputil_generic_div_float_double_double_double.Invoke(x, y);
	}
}
