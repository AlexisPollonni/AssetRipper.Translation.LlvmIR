using System;

namespace LlvmLibC.GlobalFunctions;

internal static partial class fmaximum_mag_numf16
{
	public static Half Invoke(Half x, Half y)
	{
		return Float16_fputil_fmaximum_mag_num_Float16_0_Float16_Float16.Invoke(x, y);
	}
}
