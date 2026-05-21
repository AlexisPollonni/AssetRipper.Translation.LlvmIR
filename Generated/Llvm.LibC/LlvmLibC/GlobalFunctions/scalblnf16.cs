using System;

namespace LlvmLibC.GlobalFunctions;

internal static partial class scalblnf16
{
	public static Half Invoke(Half x, long n)
	{
		return fputil_ldexp_Float16_long.Invoke(x, n);
	}
}
