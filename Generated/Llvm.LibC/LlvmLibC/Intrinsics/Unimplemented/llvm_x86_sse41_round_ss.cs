using System;
using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;

namespace LlvmLibC.Intrinsics.Unimplemented;

[MangledName("llvm.x86.sse41.round.ss")]
[DemangledName("llvm.x86.sse41.round.ss")]
internal static partial class llvm_x86_sse41_round_ss
{
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static InlineArray4_Single Invoke(InlineArray4_Single parameter_0, InlineArray4_Single parameter_1, int parameter_2)
	{
		throw new NotImplementedException("Unimplemented LLVM intrinsic: llvm.x86.sse41.round.ss");
	}
}
