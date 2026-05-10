using System;

namespace LlvmLibC.GlobalFunctions;

internal static partial class frexpf16
{
	public unsafe static Half Invoke(Half x, void* exp)
	{
		return Float16_fputil_frexp_Float16_0_Float16_int.Invoke(x, exp);
	}
}
