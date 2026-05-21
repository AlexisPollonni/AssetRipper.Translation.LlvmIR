using System;

namespace LlvmLibC.GlobalFunctions;

internal static partial class modff16
{
	public unsafe static Half Invoke(Half x, void* iptr)
	{
		return fputil_modf_Float16_0.Invoke(x, iptr);
	}
}
