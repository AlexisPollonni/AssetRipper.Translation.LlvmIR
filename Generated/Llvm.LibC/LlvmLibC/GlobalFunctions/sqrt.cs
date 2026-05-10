namespace LlvmLibC.GlobalFunctions;

internal static partial class sqrt
{
	public static double Invoke(double x)
	{
		return cpp_enable_if_cpp_is_floating_point_v_double_cpp_is_floating_point_v_double_sizeof_double_sizeof_double_double_type_fputil_sqrt_double_double_double.Invoke(x);
	}
}
