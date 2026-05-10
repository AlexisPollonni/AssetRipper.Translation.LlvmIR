namespace LlvmLibC.GlobalFunctions;

internal static partial class llogbf128
{
	public static long Invoke(double x)
	{
		return cpp_enable_if_cpp_is_floating_point_v_float128_long_type_fputil_intlogb_long_float128_float128.Invoke(x);
	}
}
