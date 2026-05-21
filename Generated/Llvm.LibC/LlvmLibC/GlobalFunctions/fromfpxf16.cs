using System;

namespace LlvmLibC.GlobalFunctions;

internal static partial class fromfpxf16
{
	public static Half Invoke(Half x, int rnd, int width)
	{
		return fputil_fromfpx_true_Float16.Invoke(x, rnd, width);
	}
}
