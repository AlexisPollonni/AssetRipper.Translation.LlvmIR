namespace LlvmLibC.GlobalFunctions;

internal static partial class ufromfpl
{
	public static double Invoke(double x, int rnd, int width)
	{
		return cpp_enable_if_cpp_is_floating_point_v_long_double_long_double_type_fputil_fromfp_false_long_double_long_double_int_unsigned_int.Invoke(x, rnd, width);
	}
}
