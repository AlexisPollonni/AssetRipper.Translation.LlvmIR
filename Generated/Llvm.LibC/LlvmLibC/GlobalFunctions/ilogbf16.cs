using System;

namespace LlvmLibC.GlobalFunctions;

internal static partial class ilogbf16
{
	public static int Invoke(Half x)
	{
		return cpp_enable_if_cpp_is_floating_point_v_Float16_int_type_fputil_intlogb_int_Float16_Float16.Invoke(x);
	}
}
