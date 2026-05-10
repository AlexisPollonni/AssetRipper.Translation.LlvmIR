namespace LlvmLibC.GlobalFunctions;

internal static partial class getpayloadl
{
	public unsafe static double Invoke(void* x)
	{
		return cpp_enable_if_cpp_is_floating_point_v_long_double_long_double_type_fputil_getpayload_long_double_long_double.Invoke(*unchecked((double*)x));
	}
}
