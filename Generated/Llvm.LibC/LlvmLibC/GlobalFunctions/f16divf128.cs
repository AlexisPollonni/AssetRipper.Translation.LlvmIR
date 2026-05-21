using System;

namespace LlvmLibC.GlobalFunctions;

internal static partial class f16divf128
{
	public static Half Invoke(double x, double y)
	{
		return generic_div_Float16_float128.Invoke(x, y);
	}
}
