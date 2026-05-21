using System;

namespace LlvmLibC.GlobalFunctions;

internal static partial class roundf16
{
	public static Half Invoke(Half x)
	{
		return fputil_round_Float16_0.Invoke(x);
	}
}
