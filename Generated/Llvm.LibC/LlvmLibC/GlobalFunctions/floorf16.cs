using System;

namespace LlvmLibC.GlobalFunctions;

internal static partial class floorf16
{
	public static Half Invoke(Half x)
	{
		return fputil_floor_Float16_0.Invoke(x);
	}
}
