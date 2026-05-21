using System;

namespace LlvmLibC.GlobalFunctions;

internal static partial class scalbnf16
{
	public static Half Invoke(Half x, int n)
	{
		return fputil_ldexp_Float16_int.Invoke(x, n);
	}
}
