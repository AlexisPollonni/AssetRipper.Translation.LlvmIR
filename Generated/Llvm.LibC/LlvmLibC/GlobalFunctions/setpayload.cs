namespace LlvmLibC.GlobalFunctions;

internal static partial class setpayload
{
	public unsafe static int Invoke(void* res, double pl)
	{
		return cpp_enable_if_cpp_is_floating_point_v_double_bool_type_fputil_setpayload_false_double_double_double.Invoke(res, pl) ? 1 : 0;
	}
}
