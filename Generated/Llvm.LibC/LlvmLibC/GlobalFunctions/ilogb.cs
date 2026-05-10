namespace LlvmLibC.GlobalFunctions;

internal static partial class ilogb
{
	public static int Invoke(double x)
	{
		return cpp_enable_if_cpp_is_floating_point_v_double_int_type_fputil_intlogb_int_double_double.Invoke(x);
	}
}
