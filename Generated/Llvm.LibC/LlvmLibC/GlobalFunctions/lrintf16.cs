using System;

namespace LlvmLibC.GlobalFunctions;

internal static partial class lrintf16
{
	public static long Invoke(Half x)
	{
		return long_fputil_round_to_signed_integer_using_current_rounding_mode_Float16_long_0_Float16.Invoke(x);
	}
}
