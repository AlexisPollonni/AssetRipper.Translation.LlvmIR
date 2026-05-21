using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Ceilf16
{
	[MangledName("ceilf16")]
	[DemangledName("ceilf16")]
	public static Half Invoke([MangledName("x")] Half X)
	{
		return Fputil_ceil_Float16_0.Invoke(X);
	}
}
