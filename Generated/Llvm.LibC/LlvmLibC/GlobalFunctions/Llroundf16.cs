using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Llroundf16
{
	[MangledName("llroundf16")]
	[DemangledName("llroundf16")]
	public static long Invoke([MangledName("x")] Half X)
	{
		return Fputil_round_to_signed_integer_Float16_long_long_0.Invoke(X);
	}
}
