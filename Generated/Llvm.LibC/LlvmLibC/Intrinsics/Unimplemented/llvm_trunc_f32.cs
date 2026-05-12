using System;
using System.Runtime.CompilerServices;
using LlvmLibC.Helpers;

namespace LlvmLibC.Intrinsics.Unimplemented;

[MangledName("llvm.trunc.f32")]
[DemangledName("llvm.trunc.f32")]
internal static partial class llvm_trunc_f32
{
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float Invoke(float parameter_0)
	{
		throw new NotImplementedException("Unimplemented LLVM intrinsic: llvm.trunc.f32");
	}
}
