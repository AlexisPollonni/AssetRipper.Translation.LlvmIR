using System;

namespace LlvmLibC.GlobalFunctions;

internal static partial class getpayloadf16
{
	public unsafe static Half Invoke(void* x)
	{
		return cpp_enable_if_cpp_is_floating_point_v_Float16_Float16_type_fputil_getpayload_Float16_Float16.Invoke(*unchecked((Half*)x));
	}
}
