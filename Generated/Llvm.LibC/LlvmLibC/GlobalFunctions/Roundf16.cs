using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Roundf16
{
	[MangledName("roundf16")]
	[DemangledName("roundf16")]
	public static Half Invoke([MangledName("x")] Half X)
	{
		return Fputil_round_Float16_0.Invoke(X);
	}
}
