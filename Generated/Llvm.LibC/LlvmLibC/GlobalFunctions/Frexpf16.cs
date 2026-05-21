using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Frexpf16
{
	[MangledName("frexpf16")]
	[DemangledName("frexpf16")]
	public unsafe static Half Invoke([MangledName("x")] Half X, [MangledName("exp")] void* Exp)
	{
		return Fputil_frexp_Float16_0.Invoke(X, Exp);
	}
}
