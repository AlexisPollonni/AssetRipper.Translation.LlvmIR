using System;

namespace LlvmLibC.GlobalFunctions;

internal static partial class llogbf16
{
	public static long Invoke(Half x)
	{
		return fputil_intlogb_long_Float16.Invoke(x);
	}
}
