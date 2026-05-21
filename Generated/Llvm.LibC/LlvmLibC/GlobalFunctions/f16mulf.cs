using System;

namespace LlvmLibC.GlobalFunctions;

internal static partial class f16mulf
{
	public static Half Invoke(float x, float y)
	{
		return generic_mul_Float16_float.Invoke(x, y);
	}
}
