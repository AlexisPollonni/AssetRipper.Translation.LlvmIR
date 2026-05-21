using System;

namespace LlvmLibC.GlobalFunctions;

internal static partial class fdimf16
{
	public static Half Invoke(Half x, Half y)
	{
		return fputil_fdim_Float16_0.Invoke(x, y);
	}
}
