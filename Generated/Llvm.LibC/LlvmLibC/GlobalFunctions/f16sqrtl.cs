using System;

namespace LlvmLibC.GlobalFunctions;

internal static partial class f16sqrtl
{
	public static Half Invoke(double x)
	{
		return fputil_sqrt_Float16_long_double.Invoke(x);
	}
}
