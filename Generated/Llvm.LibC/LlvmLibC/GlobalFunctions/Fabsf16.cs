using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Fabsf16
{
	[MangledName("fabsf16")]
	[DemangledName("fabsf16")]
	public static Half Invoke([MangledName("x")] Half X)
	{
		return Llvm_fabs_f16.Invoke(X);
	}
}
