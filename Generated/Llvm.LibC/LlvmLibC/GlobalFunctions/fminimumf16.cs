using System;

namespace LlvmLibC.GlobalFunctions;

internal static partial class fminimumf16
{
	public static Half Invoke(Half x, Half y)
	{
		return fputil_fminimum_Float16_0.Invoke(x, y);
	}
}
