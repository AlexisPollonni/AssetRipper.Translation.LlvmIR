using System;
using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.Intrinsics.Unimplemented;

[MangledName("llvm.minnum.f16")]
[DemangledName("llvm.minnum.f16")]
internal static partial class llvm_minnum_f16
{
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Half Invoke(Half parameter_0, Half parameter_1)
	{
		throw new NotImplementedException("Unimplemented LLVM intrinsic: llvm.minnum.f16");
	}
}
