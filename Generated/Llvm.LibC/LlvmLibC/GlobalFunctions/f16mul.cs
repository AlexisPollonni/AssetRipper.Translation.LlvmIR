using System;

namespace LlvmLibC.GlobalFunctions;

internal static partial class f16mul
{
	public static Half Invoke(double x, double y)
	{
		return generic_mul_Float16_double.Invoke(x, y);
	}
}
