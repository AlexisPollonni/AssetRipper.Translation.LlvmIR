using System;

namespace LlvmLibC.GlobalFunctions;

internal static partial class ceilf16
{
	public static Half Invoke(Half x)
	{
		return fputil_ceil_Float16_0.Invoke(x);
	}
}
