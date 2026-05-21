using System;

namespace LlvmLibC.GlobalFunctions;

internal static partial class rintf16
{
	public static Half Invoke(Half x)
	{
		return fputil_round_using_current_rounding_mode_Float16.Invoke(x);
	}
}
