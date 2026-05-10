using System;

namespace LlvmLibC.GlobalFunctions;

internal static partial class truncf16
{
	public static Half Invoke(Half x)
	{
		return Float16_fputil_trunc_Float16_0_Float16.Invoke(x);
	}
}
