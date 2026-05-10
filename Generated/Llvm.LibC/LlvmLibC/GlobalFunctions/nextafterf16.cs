using System;

namespace LlvmLibC.GlobalFunctions;

internal static partial class nextafterf16
{
	public static Half Invoke(Half x, Half y)
	{
		return Float16_fputil_nextafter_Float16_Float16_0_Float16_Float16.Invoke(x, y);
	}
}
