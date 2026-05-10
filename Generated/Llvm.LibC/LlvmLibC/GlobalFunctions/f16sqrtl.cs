using System;

namespace LlvmLibC.GlobalFunctions;

internal static partial class f16sqrtl
{
	public static Half Invoke(double x)
	{
		return cpp_enable_if_cpp_is_floating_point_v_Float16_cpp_is_floating_point_v_long_double_sizeof_Float16_sizeof_long_double_Float16_type_fputil_sqrt_Float16_long_double_long_double.Invoke(x);
	}
}
