using System;
using System.Runtime.CompilerServices;
using LlvmLibC.Helpers;

namespace LlvmLibC.Intrinsics.Unimplemented;

[MangledName("llvm.ptrmask.p0.i64")]
[DemangledName("llvm.ptrmask.p0.i64")]
internal static partial class llvm_ptrmask_p0_i64
{
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public unsafe static void* Invoke(void* parameter_0, long parameter_1)
	{
		throw new NotImplementedException("Unimplemented LLVM intrinsic: llvm.ptrmask.p0.i64");
	}
}
