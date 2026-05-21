using System;

namespace LlvmLibC.GlobalFunctions;

internal static partial class fmodf16
{
	public static Half Invoke(Half x, Half y)
	{
		return FMod_Float16_unsigned_int_fputil_generic_FModDivisionSimpleHelper_unsigned_int_eval.Invoke(x, y);
	}
}
