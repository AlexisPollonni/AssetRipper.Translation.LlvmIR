using System;

namespace LlvmLibC.GlobalFunctions;

internal static partial class fmodf16
{
	public static Half Invoke(Half x, Half y)
	{
		return fputil_generic_FMod_Float16_unsigned_int_fputil_generic_FModDivisionSimpleHelper_unsigned_int_eval_Float16_Float16.Invoke(x, y);
	}
}
