using System;

namespace LlvmLibC.GlobalFunctions;

internal static partial class fminimum_mag_numf16
{
	public static Half Invoke(Half x, Half y)
	{
		return fputil_fminimum_mag_num_Float16_0.Invoke(x, y);
	}
}
