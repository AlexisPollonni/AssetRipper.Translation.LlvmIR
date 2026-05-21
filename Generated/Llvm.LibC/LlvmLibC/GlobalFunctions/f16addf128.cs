using System;

namespace LlvmLibC.GlobalFunctions;

internal static partial class f16addf128
{
	public static Half Invoke(double x, double y)
	{
		return generic_add_Float16_float128.Invoke(x, y);
	}
}
