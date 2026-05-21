using System;

namespace LlvmLibC.GlobalFunctions;

internal static partial class f16subf
{
	public static Half Invoke(float x, float y)
	{
		return generic_sub_Float16_float.Invoke(x, y);
	}
}
