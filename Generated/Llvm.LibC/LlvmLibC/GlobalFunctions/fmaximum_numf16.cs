using System;

namespace LlvmLibC.GlobalFunctions;

internal static partial class fmaximum_numf16
{
	public static Half Invoke(Half x, Half y)
	{
		return fputil_fmaximum_num_Float16_0.Invoke(x, y);
	}
}
