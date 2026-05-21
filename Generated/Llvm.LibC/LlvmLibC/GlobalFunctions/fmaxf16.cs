using System;

namespace LlvmLibC.GlobalFunctions;

internal static partial class fmaxf16
{
	public static Half Invoke(Half x, Half y)
	{
		return fputil_fmax_Float16_0.Invoke(x, y);
	}
}
