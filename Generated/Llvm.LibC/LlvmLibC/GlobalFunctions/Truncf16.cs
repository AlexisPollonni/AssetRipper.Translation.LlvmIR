using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Truncf16
{
	[MangledName("truncf16")]
	[DemangledName("truncf16")]
	public static Half Invoke([MangledName("x")] Half X)
	{
		return Fputil_trunc_Float16_0.Invoke(X);
	}
}
