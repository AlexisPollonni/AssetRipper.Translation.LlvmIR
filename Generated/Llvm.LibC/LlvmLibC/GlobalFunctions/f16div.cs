using System;

namespace LlvmLibC.GlobalFunctions;

internal static partial class f16div
{
	public static Half Invoke(double x, double y)
	{
		return generic_div_Float16_double.Invoke(x, y);
	}
}
