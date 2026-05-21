using System;

namespace LlvmLibC.GlobalFunctions;

internal static partial class f16subf128
{
	public static Half Invoke(double x, double y)
	{
		return generic_sub_Float16_float128.Invoke(x, y);
	}
}
