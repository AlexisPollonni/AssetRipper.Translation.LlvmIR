using System;

namespace LlvmLibC.GlobalFunctions;

internal static partial class nextdownf16
{
	public static Half Invoke(Half x)
	{
		return fputil_nextupdown_true_Float16_0.Invoke(x);
	}
}
