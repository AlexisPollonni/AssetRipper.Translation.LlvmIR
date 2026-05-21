using System;

namespace LlvmLibC.GlobalFunctions;

internal static partial class f16sqrtf
{
	public static Half Invoke(float x)
	{
		return fputil_sqrt_Float16_float.Invoke(x);
	}
}
