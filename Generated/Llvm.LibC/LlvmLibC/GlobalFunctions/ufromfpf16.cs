using System;

namespace LlvmLibC.GlobalFunctions;

internal static partial class ufromfpf16
{
	public static Half Invoke(Half x, int rnd, int width)
	{
		return cpp_enable_if_cpp_is_floating_point_v_Float16_Float16_type_fputil_fromfp_false_Float16_Float16_int_unsigned_int.Invoke(x, rnd, width);
	}
}
