namespace LlvmLibC.GlobalFunctions;

internal static partial class getpayloadf128
{
	public unsafe static double Invoke(void* x)
	{
		return cpp_enable_if_cpp_is_floating_point_v_float128_float128_type_fputil_getpayload_float128_float128.Invoke(*unchecked((double*)x));
	}
}
