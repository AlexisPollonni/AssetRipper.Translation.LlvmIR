using System;

namespace LlvmLibC.GlobalFunctions;

internal static partial class ldexpf16
{
	public static Half Invoke(Half x, int exp)
	{
		return fputil_ldexp_Float16_int.Invoke(x, exp);
	}
}
