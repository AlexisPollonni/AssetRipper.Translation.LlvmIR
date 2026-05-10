namespace LlvmLibC.GlobalFunctions;

internal static partial class fromfpxf
{
	public static float Invoke(float x, int rnd, int width)
	{
		return cpp_enable_if_cpp_is_floating_point_v_float_float_type_fputil_fromfpx_true_float_float_int_unsigned_int.Invoke(x, rnd, width);
	}
}
