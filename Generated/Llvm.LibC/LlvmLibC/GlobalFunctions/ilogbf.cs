namespace LlvmLibC.GlobalFunctions;

internal static partial class ilogbf
{
	public static int Invoke(float x)
	{
		return cpp_enable_if_cpp_is_floating_point_v_float_int_type_fputil_intlogb_int_float_float.Invoke(x);
	}
}
