using System;

namespace LlvmLibC.GlobalFunctions;

internal static partial class scalblnf16
{
	public static Half Invoke(Half x, long n)
	{
		return cpp_enable_if_cpp_is_floating_point_v_Float16_cpp_is_integral_v_long_Float16_type_fputil_ldexp_Float16_long_Float16_long.Invoke(x, n);
	}
}
