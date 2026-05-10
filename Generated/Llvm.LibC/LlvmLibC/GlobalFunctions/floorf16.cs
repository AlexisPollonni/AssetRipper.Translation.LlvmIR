using System;

namespace LlvmLibC.GlobalFunctions;

internal static partial class floorf16
{
	public static Half Invoke(Half x)
	{
		return Float16_fputil_floor_Float16_0_Float16.Invoke(x);
	}
}
