using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Copysignf16
{
	[MangledName("copysignf16")]
	[DemangledName("copysignf16")]
	public static Half Invoke([MangledName("x")] Half X, [MangledName("y")] Half Y)
	{
		return Llvm_copysign_f16.Invoke(X, Y);
	}
}
