using System;

namespace LlvmLibC.GlobalFunctions;

internal static partial class fmaximum_mag_numf16
{
	public static Half Invoke(Half x, Half y)
	{
		return fputil_fmaximum_mag_num_Float16_0.Invoke(x, y);
	}
}
