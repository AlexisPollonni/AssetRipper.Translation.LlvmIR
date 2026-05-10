using System;

namespace LlvmLibC.GlobalFunctions;

internal static partial class roundevenf16
{
	public static Half Invoke(Half x)
	{
		return cpp_enable_if_cpp_is_floating_point_v_Float16_Float16_type_fputil_round_using_specific_rounding_mode_Float16_Float16_int.Invoke(x, 4);
	}
}
