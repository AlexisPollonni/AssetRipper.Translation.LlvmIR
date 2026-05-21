using System;

namespace LlvmLibC.GlobalFunctions;

internal static partial class llroundf16
{
	public static long Invoke(Half x)
	{
		return fputil_round_to_signed_integer_Float16_long_long_0.Invoke(x);
	}
}
