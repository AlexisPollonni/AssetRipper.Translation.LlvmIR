using System;

namespace LlvmLibC.GlobalFunctions;

internal static partial class f16add
{
	public static Half Invoke(double x, double y)
	{
		return cpp_enable_if_cpp_is_floating_point_v_Float16_cpp_is_floating_point_v_double_sizeof_Float16_sizeof_double_Float16_type_fputil_generic_add_Float16_double_double_double.Invoke(x, y);
	}
}
