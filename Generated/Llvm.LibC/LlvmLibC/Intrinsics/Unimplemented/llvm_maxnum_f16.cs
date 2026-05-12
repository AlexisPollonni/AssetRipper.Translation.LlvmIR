using System;
using System.Runtime.CompilerServices;
using LlvmLibC.Helpers;

namespace LlvmLibC.Intrinsics.Unimplemented;

[MangledName("llvm.maxnum.f16")]
[DemangledName("llvm.maxnum.f16")]
internal static partial class llvm_maxnum_f16
{
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Half Invoke(Half parameter_0, Half parameter_1)
	{
		throw new NotImplementedException("Unimplemented LLVM intrinsic: llvm.maxnum.f16");
	}
}
