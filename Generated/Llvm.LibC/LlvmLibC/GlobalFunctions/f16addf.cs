using System;

namespace LlvmLibC.GlobalFunctions;

internal static partial class f16addf
{
	public static Half Invoke(float x, float y)
	{
		return generic_add_Float16_float.Invoke(x, y);
	}
}
