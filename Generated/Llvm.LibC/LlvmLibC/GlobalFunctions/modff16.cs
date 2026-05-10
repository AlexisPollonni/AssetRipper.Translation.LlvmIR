using System;

namespace LlvmLibC.GlobalFunctions;

internal static partial class modff16
{
	public unsafe static Half Invoke(Half x, void* iptr)
	{
		return Float16_fputil_modf_Float16_0_Float16_Float16.Invoke(x, iptr);
	}
}
