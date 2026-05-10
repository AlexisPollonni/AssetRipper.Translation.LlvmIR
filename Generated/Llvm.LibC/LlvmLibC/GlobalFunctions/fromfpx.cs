namespace LlvmLibC.GlobalFunctions;

internal static partial class fromfpx
{
	public static double Invoke(double x, int rnd, int width)
	{
		return cpp_enable_if_cpp_is_floating_point_v_double_double_type_fputil_fromfpx_true_double_double_int_unsigned_int.Invoke(x, rnd, width);
	}
}
