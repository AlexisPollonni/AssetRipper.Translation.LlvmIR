using System;

namespace LlvmLibC.GlobalFunctions;

internal static partial class remquof16
{
	public unsafe static Half Invoke(Half x, Half y, void* exp)
	{
		return Float16_fputil_remquo_Float16_0_Float16_Float16_int.Invoke(x, y, exp);
	}
}
