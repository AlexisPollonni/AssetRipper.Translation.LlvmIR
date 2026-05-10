using System;

namespace LlvmLibC.GlobalFunctions;

internal static partial class f16fmaf
{
	public static Half Invoke(float x, float y, float z)
	{
		return Float16_fputil_fma_Float16_float_float_float_float.Invoke(x, y, z);
	}
}
