using System;

namespace LlvmLibC.GlobalFunctions;

internal static partial class totalordermagf16
{
	public unsafe static int Invoke(void* x, void* y)
	{
		return unchecked(cpp_enable_if_cpp_is_floating_point_v_Float16_bool_type_fputil_totalordermag_Float16_Float16_Float16.Invoke(*(Half*)x, *(Half*)y)) ? 1 : 0;
	}
}
