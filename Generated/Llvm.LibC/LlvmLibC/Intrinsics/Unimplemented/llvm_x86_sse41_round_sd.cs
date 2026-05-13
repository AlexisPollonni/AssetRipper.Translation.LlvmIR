using System;
using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;

namespace LlvmLibC.Intrinsics.Unimplemented;

[MangledName("llvm.x86.sse41.round.sd")]
[DemangledName("llvm.x86.sse41.round.sd")]
internal static partial class llvm_x86_sse41_round_sd
{
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static InlineArray2_Double Invoke(InlineArray2_Double parameter_0, InlineArray2_Double parameter_1, int parameter_2)
	{
		throw new NotImplementedException("Unimplemented LLVM intrinsic: llvm.x86.sse41.round.sd");
	}
}
