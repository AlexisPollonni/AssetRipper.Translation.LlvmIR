using System;

namespace LlvmLibC.GlobalFunctions;

internal static partial class fminf16
{
	public static Half Invoke(Half x, Half y)
	{
		return fputil_fmin_Float16_0.Invoke(x, y);
	}
}
