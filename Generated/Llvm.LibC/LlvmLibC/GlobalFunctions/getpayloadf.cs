namespace LlvmLibC.GlobalFunctions;

internal static partial class getpayloadf
{
	public unsafe static float Invoke(void* x)
	{
		return cpp_enable_if_cpp_is_floating_point_v_float_float_type_fputil_getpayload_float_float.Invoke(*unchecked((float*)x));
	}
}
