using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Fmodf16
{
	[MangledName("fmodf16")]
	[DemangledName("fmodf16")]
	public static Half Invoke([MangledName("x")] Half X, [MangledName("y")] Half Y)
	{
		return FMod_Float16_unsigned_int_fputil_generic_FModDivisionSimpleHelper_unsigned_int_eval.Invoke(X, Y);
	}
}
