using System;

namespace LlvmLibC.GlobalFunctions;

internal static partial class truncf16
{
	public static Half Invoke(Half x)
	{
		return fputil_trunc_Float16_0.Invoke(x);
	}
}
