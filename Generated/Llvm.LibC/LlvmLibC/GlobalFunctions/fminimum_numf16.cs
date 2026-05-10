using System;

namespace LlvmLibC.GlobalFunctions;

internal static partial class fminimum_numf16
{
	public static Half Invoke(Half x, Half y)
	{
		return Float16_fputil_fminimum_num_Float16_0_Float16_Float16.Invoke(x, y);
	}
}
