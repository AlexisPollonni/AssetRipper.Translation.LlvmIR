namespace LlvmLibC.GlobalFunctions;

internal static partial class ilogbf128
{
	public static int Invoke(double x)
	{
		return cpp_enable_if_cpp_is_floating_point_v_float128_int_type_fputil_intlogb_int_float128_float128.Invoke(x);
	}
}
