namespace LlvmLibC.GlobalFunctions;

internal static partial class ufromfp
{
	public static double Invoke(double x, int rnd, int width)
	{
		return cpp_enable_if_cpp_is_floating_point_v_double_double_type_fputil_fromfp_false_double_double_int_unsigned_int.Invoke(x, rnd, width);
	}
}
