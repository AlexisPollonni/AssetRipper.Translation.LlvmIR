using System;

namespace LlvmLibC.GlobalFunctions;

internal static partial class f16sqrt
{
	public static Half Invoke(double x)
	{
		return cpp_enable_if_cpp_is_floating_point_v_Float16_cpp_is_floating_point_v_double_sizeof_Float16_sizeof_double_Float16_type_fputil_sqrt_Float16_double_double.Invoke(x);
	}
}
