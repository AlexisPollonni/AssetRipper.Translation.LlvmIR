using System;

namespace LlvmLibC.GlobalFunctions;

internal static partial class logbf16
{
	public static Half Invoke(Half x)
	{
		return fputil_logb_Float16_0.Invoke(x);
	}
}
