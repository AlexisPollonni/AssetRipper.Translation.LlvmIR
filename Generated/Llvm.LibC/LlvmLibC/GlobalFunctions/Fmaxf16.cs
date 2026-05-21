using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Fmaxf16
{
	[MangledName("fmaxf16")]
	[DemangledName("fmaxf16")]
	public static Half Invoke([MangledName("x")] Half X, [MangledName("y")] Half Y)
	{
		return Fputil_fmax_Float16_0.Invoke(X, Y);
	}
}
