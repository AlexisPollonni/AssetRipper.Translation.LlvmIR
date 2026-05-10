namespace LlvmLibC.GlobalFunctions;

internal static partial class llogb
{
	public static long Invoke(double x)
	{
		return cpp_enable_if_cpp_is_floating_point_v_double_long_type_fputil_intlogb_long_double_double.Invoke(x);
	}
}
