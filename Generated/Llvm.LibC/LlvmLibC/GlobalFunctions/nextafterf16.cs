using System;

namespace LlvmLibC.GlobalFunctions;

internal static partial class nextafterf16
{
	public static Half Invoke(Half x, Half y)
	{
		return fputil_nextafter_Float16_Float16_0.Invoke(x, y);
	}
}
