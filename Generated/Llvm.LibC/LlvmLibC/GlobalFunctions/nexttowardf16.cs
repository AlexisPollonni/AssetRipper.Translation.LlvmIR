using System;

namespace LlvmLibC.GlobalFunctions;

internal static partial class nexttowardf16
{
	public static Half Invoke(Half x, double y)
	{
		return fputil_nextafter_Float16_long_double_0.Invoke(x, y);
	}
}
