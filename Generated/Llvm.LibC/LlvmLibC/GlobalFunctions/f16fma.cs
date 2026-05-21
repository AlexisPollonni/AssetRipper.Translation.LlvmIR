using System;

namespace LlvmLibC.GlobalFunctions;

internal static partial class f16fma
{
	public static Half Invoke(double x, double y, double z)
	{
		return fputil_fma_Float16_double.Invoke(x, y, z);
	}
}
