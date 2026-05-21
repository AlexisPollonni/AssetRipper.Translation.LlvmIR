using System;

namespace LlvmLibC.GlobalFunctions;

internal static partial class fromfpf16
{
	public static Half Invoke(Half x, int rnd, int width)
	{
		return fputil_fromfp_true_Float16.Invoke(x, rnd, width);
	}
}
