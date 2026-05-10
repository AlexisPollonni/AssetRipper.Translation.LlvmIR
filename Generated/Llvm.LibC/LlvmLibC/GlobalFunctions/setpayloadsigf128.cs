namespace LlvmLibC.GlobalFunctions;

internal static partial class setpayloadsigf128
{
	public unsafe static int Invoke(void* res, double pl)
	{
		return cpp_enable_if_cpp_is_floating_point_v_float128_bool_type_fputil_setpayload_true_float128_float128_float128.Invoke(res, pl) ? 1 : 0;
	}
}
