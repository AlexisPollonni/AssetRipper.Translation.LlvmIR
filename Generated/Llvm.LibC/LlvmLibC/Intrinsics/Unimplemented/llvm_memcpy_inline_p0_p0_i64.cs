using System;
using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.Intrinsics.Unimplemented;

[MangledName("llvm.memcpy.inline.p0.p0.i64")]
[DemangledName("llvm.memcpy.inline.p0.p0.i64")]
internal static partial class llvm_memcpy_inline_p0_p0_i64
{
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public unsafe static void Invoke(void* parameter_0, void* parameter_1, long parameter_2, bool parameter_3)
	{
		throw new NotImplementedException("Unimplemented LLVM intrinsic: llvm.memcpy.inline.p0.p0.i64");
	}
}
