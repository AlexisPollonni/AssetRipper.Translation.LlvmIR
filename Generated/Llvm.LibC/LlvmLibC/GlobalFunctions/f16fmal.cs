using System;

namespace LlvmLibC.GlobalFunctions;

internal static partial class f16fmal
{
	public static Half Invoke(double x, double y, double z)
	{
		return fputil_fma_Float16_long_double.Invoke(x, y, z);
	}
}
