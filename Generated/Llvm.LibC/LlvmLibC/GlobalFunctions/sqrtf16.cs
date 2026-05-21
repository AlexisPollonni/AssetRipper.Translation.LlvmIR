using System;

namespace LlvmLibC.GlobalFunctions;

internal static partial class sqrtf16
{
	public static Half Invoke(Half x)
	{
		return fputil_sqrt_Float16_Float16.Invoke(x);
	}
}
