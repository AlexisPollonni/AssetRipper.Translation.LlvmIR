using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Fdimf16
{
	[MangledName("fdimf16")]
	[DemangledName("fdimf16")]
	public static Half Invoke([MangledName("x")] Half X, [MangledName("y")] Half Y)
	{
		return Fputil_fdim_Float16_0.Invoke(X, Y);
	}
}
