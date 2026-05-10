using System;

namespace LlvmLibC.GlobalFunctions;

internal static partial class nextdownf16
{
	public static Half Invoke(Half x)
	{
		return Float16_fputil_nextupdown_true_Float16_0_Float16.Invoke(x);
	}
}
