using System;

namespace LlvmLibC.GlobalFunctions;

internal static partial class f16fmaf128
{
	public static Half Invoke(double x, double y, double z)
	{
		return Float16_fputil_fma_Float16_float128_float128_float128_float128.Invoke(x, y, z);
	}
}
