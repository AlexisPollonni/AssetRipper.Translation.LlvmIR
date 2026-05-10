using System;

namespace LlvmLibC.GlobalFunctions;

internal static partial class llogbf16
{
	public static long Invoke(Half x)
	{
		return cpp_enable_if_cpp_is_floating_point_v_Float16_long_type_fputil_intlogb_long_Float16_Float16.Invoke(x);
	}
}
