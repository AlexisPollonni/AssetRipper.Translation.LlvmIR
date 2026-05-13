using System;
using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.Intrinsics.Unimplemented;

[MangledName("llvm.threadlocal.address.p0")]
[DemangledName("llvm.threadlocal.address.p0")]
internal static partial class llvm_threadlocal_address_p0
{
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public unsafe static void* Invoke(void* parameter_0)
	{
		throw new NotImplementedException("Unimplemented LLVM intrinsic: llvm.threadlocal.address.p0");
	}
}
