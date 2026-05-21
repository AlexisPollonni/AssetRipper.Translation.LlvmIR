using System;

namespace LlvmLibC.GlobalFunctions;

internal static partial class ilogbf16
{
	public static int Invoke(Half x)
	{
		return fputil_intlogb_int_Float16.Invoke(x);
	}
}
