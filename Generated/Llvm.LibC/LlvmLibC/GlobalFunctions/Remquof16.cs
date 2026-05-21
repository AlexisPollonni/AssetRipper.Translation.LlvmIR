using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Remquof16
{
	[MangledName("remquof16")]
	[DemangledName("remquof16")]
	public unsafe static Half Invoke([MangledName("x")] Half X, [MangledName("y")] Half Y, [MangledName("exp")] void* Exp)
	{
		return Fputil_remquo_Float16_0.Invoke(X, Y, Exp);
	}
}
