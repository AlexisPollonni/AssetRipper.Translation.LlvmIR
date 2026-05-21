using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Modff16
{
	[MangledName("modff16")]
	[DemangledName("modff16")]
	public unsafe static Half Invoke([MangledName("x")] Half X, [MangledName("iptr")] void* Iptr)
	{
		return Fputil_modf_Float16_0.Invoke(X, Iptr);
	}
}
