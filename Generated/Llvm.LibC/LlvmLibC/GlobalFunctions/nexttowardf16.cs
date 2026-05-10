using System;

namespace LlvmLibC.GlobalFunctions;

internal static partial class nexttowardf16
{
	public static Half Invoke(Half x, double y)
	{
		return Float16_fputil_nextafter_Float16_long_double_0_Float16_long_double.Invoke(x, y);
	}
}
