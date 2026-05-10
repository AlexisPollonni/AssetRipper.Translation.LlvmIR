namespace LlvmLibC.GlobalFunctions;

internal static partial class sqrtf
{
	public static float Invoke(float x)
	{
		return cpp_enable_if_cpp_is_floating_point_v_float_cpp_is_floating_point_v_float_sizeof_float_sizeof_float_float_type_fputil_sqrt_float_float_float.Invoke(x);
	}
}
