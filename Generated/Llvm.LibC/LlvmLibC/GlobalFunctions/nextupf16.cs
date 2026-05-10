using System;

namespace LlvmLibC.GlobalFunctions;

internal static partial class nextupf16
{
	public static Half Invoke(Half x)
	{
		return Float16_fputil_nextupdown_false_Float16_0_Float16.Invoke(x);
	}
}
