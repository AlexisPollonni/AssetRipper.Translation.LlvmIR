using System;

namespace LlvmLibC.GlobalFunctions;

internal static partial class roundf16
{
	public static Half Invoke(Half x)
	{
		return Float16_fputil_round_Float16_0_Float16.Invoke(x);
	}
}
