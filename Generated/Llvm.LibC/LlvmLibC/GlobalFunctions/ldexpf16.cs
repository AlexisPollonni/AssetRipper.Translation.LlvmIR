using System;

namespace LlvmLibC.GlobalFunctions;

internal static partial class ldexpf16
{
	public static Half Invoke(Half x, int exp)
	{
		return cpp_enable_if_cpp_is_floating_point_v_Float16_cpp_is_integral_v_int_Float16_type_fputil_ldexp_Float16_int_Float16_int.Invoke(x, exp);
	}
}
