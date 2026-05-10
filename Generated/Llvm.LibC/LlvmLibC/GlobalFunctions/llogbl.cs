namespace LlvmLibC.GlobalFunctions;

internal static partial class llogbl
{
	public static long Invoke(double x)
	{
		return cpp_enable_if_cpp_is_floating_point_v_long_double_long_type_fputil_intlogb_long_long_double_long_double.Invoke(x);
	}
}
