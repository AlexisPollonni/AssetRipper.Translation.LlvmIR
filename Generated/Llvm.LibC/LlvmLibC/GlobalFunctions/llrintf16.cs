using System;

namespace LlvmLibC.GlobalFunctions;

internal static partial class llrintf16
{
	public static long Invoke(Half x)
	{
		return fputil_round_to_signed_integer_using_current_rounding_mode_Float16_long_long_0.Invoke(x);
	}
}
