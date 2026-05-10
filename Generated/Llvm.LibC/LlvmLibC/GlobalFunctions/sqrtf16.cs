using System;

namespace LlvmLibC.GlobalFunctions;

internal static partial class sqrtf16
{
	public static Half Invoke(Half x)
	{
		return cpp_enable_if_cpp_is_floating_point_v_Float16_cpp_is_floating_point_v_Float16_sizeof_Float16_sizeof_Float16_Float16_type_fputil_sqrt_Float16_Float16_Float16.Invoke(x);
	}
}
