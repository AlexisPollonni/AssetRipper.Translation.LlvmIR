using System;

namespace LlvmLibC.GlobalFunctions;

internal static partial class setpayloadf16
{
	public unsafe static int Invoke(void* res, Half pl)
	{
		return cpp_enable_if_cpp_is_floating_point_v_Float16_bool_type_fputil_setpayload_false_Float16_Float16_Float16.Invoke(res, pl) ? 1 : 0;
	}
}
