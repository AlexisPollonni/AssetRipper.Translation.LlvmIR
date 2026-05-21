using System;

namespace LlvmLibC.GlobalFunctions;

internal static partial class f16divf
{
	public static Half Invoke(float x, float y)
	{
		return generic_div_Float16_float.Invoke(x, y);
	}
}
