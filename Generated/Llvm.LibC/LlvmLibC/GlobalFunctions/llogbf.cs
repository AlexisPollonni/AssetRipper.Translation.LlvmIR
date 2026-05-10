namespace LlvmLibC.GlobalFunctions;

internal static partial class llogbf
{
	public static long Invoke(float x)
	{
		return cpp_enable_if_cpp_is_floating_point_v_float_long_type_fputil_intlogb_long_float_float.Invoke(x);
	}
}
