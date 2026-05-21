using System;

namespace LlvmLibC.GlobalFunctions;

internal static partial class remquof16
{
	public unsafe static Half Invoke(Half x, Half y, void* exp)
	{
		return fputil_remquo_Float16_0.Invoke(x, y, exp);
	}
}
