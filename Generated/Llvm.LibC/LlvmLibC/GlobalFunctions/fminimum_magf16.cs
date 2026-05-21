using System;

namespace LlvmLibC.GlobalFunctions;

internal static partial class fminimum_magf16
{
	public static Half Invoke(Half x, Half y)
	{
		return fputil_fminimum_mag_Float16_0.Invoke(x, y);
	}
}
