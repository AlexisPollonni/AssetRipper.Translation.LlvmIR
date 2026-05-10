using System;

namespace LlvmLibC.GlobalFunctions;

internal static partial class f16divf
{
	public static Half Invoke(float x, float y)
	{
		return cpp_enable_if_cpp_is_floating_point_v_Float16_cpp_is_floating_point_v_float_sizeof_Float16_sizeof_float_Float16_type_fputil_generic_div_Float16_float_float_float.Invoke(x, y);
	}
}
