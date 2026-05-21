using System;

namespace LlvmLibC.GlobalFunctions;

internal static partial class roundevenf16
{
	public static Half Invoke(Half x)
	{
		return fputil_round_using_specific_rounding_mode_Float16.Invoke(x, 4);
	}
}
