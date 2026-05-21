using System;

namespace LlvmLibC.GlobalFunctions;

internal static partial class f16sub
{
	public static Half Invoke(double x, double y)
	{
		return generic_sub_Float16_double.Invoke(x, y);
	}
}
