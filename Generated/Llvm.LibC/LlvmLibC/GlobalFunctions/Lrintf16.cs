using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Lrintf16
{
	[MangledName("lrintf16")]
	[DemangledName("lrintf16")]
	public static long Invoke([MangledName("x")] Half X)
	{
		return Fputil_round_to_signed_integer_using_current_rounding_mode_Float16_long_0.Invoke(X);
	}
}
