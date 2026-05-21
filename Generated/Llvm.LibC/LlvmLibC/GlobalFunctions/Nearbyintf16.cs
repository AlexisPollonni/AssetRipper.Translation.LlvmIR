using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Nearbyintf16
{
	[MangledName("nearbyintf16")]
	[DemangledName("nearbyintf16")]
	public static Half Invoke([MangledName("x")] Half X)
	{
		return Fputil_round_using_current_rounding_mode_Float16.Invoke(X);
	}
}
