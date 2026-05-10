namespace LlvmLibC.GlobalFunctions;

internal static partial class ufromfpf128
{
	public static double Invoke(double x, int rnd, int width)
	{
		return cpp_enable_if_cpp_is_floating_point_v_float128_float128_type_fputil_fromfp_false_float128_float128_int_unsigned_int.Invoke(x, rnd, width);
	}
}
