namespace LlvmLibC.GlobalFunctions;

internal static partial class setpayloadf
{
	public unsafe static int Invoke(void* res, float pl)
	{
		return cpp_enable_if_cpp_is_floating_point_v_float_bool_type_fputil_setpayload_false_float_float_float.Invoke(res, pl) ? 1 : 0;
	}
}
