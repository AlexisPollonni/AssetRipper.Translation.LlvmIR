using System;

namespace LlvmLibC.GlobalFunctions;

internal static partial class frexpf16
{
	public unsafe static Half Invoke(Half x, void* exp)
	{
		return fputil_frexp_Float16_0.Invoke(x, exp);
	}
}
