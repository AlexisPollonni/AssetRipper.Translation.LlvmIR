namespace LlvmLibC.GlobalFunctions;

internal static partial class ilogbl
{
	public static int Invoke(double x)
	{
		return cpp_enable_if_cpp_is_floating_point_v_long_double_int_type_fputil_intlogb_int_long_double_long_double.Invoke(x);
	}
}
