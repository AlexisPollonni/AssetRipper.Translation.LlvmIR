namespace LlvmLibC.GlobalFunctions;

internal static partial class setpayloadsigl
{
	public unsafe static int Invoke(void* res, double pl)
	{
		return cpp_enable_if_cpp_is_floating_point_v_long_double_bool_type_fputil_setpayload_true_long_double_long_double_long_double.Invoke(res, pl) ? 1 : 0;
	}
}
