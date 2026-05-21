using System;

namespace LlvmLibC.GlobalFunctions;

internal static partial class f16divl
{
	public static Half Invoke(double x, double y)
	{
		return generic_div_Float16_long_double.Invoke(x, y);
	}
}
