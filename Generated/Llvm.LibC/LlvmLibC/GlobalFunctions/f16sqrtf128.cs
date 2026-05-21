using System;

namespace LlvmLibC.GlobalFunctions;

internal static partial class f16sqrtf128
{
	public static Half Invoke(double x)
	{
		return fputil_sqrt_Float16_float128.Invoke(x);
	}
}
