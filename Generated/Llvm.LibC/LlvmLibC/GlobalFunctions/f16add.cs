using System;

namespace LlvmLibC.GlobalFunctions;

internal static partial class f16add
{
	public static Half Invoke(double x, double y)
	{
		return generic_add_Float16_double.Invoke(x, y);
	}
}
