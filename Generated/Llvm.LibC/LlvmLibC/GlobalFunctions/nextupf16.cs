using System;

namespace LlvmLibC.GlobalFunctions;

internal static partial class nextupf16
{
	public static Half Invoke(Half x)
	{
		return fputil_nextupdown_false_Float16_0.Invoke(x);
	}
}
