using System;

namespace LlvmLibC.GlobalFunctions;

internal static partial class f16addl
{
	public static Half Invoke(double x, double y)
	{
		return generic_add_Float16_long_double.Invoke(x, y);
	}
}
