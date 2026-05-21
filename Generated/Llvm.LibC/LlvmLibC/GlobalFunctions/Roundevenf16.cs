using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Roundevenf16
{
	[MangledName("roundevenf16")]
	[DemangledName("roundevenf16")]
	public static Half Invoke([MangledName("x")] Half X)
	{
		return Fputil_round_using_specific_rounding_mode_Float16.Invoke(X, 4);
	}
}
