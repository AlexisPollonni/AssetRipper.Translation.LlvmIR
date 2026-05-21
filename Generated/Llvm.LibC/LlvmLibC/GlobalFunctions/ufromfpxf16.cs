using System;

namespace LlvmLibC.GlobalFunctions;

internal static partial class ufromfpxf16
{
	public static Half Invoke(Half x, int rnd, int width)
	{
		return fputil_fromfpx_false_Float16.Invoke(x, rnd, width);
	}
}
