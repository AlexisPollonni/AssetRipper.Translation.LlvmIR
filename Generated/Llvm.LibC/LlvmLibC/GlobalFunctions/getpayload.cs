namespace LlvmLibC.GlobalFunctions;

internal static partial class getpayload
{
	public unsafe static double Invoke(void* x)
	{
		return cpp_enable_if_cpp_is_floating_point_v_double_double_type_fputil_getpayload_double_double.Invoke(*unchecked((double*)x));
	}
}
