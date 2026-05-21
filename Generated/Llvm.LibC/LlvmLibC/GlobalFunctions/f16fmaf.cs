using System;

namespace LlvmLibC.GlobalFunctions;

internal static partial class f16fmaf
{
	public static Half Invoke(float x, float y, float z)
	{
		return fputil_fma_Float16_float.Invoke(x, y, z);
	}
}
