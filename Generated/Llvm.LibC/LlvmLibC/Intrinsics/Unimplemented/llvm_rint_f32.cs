using System;
using System.Runtime.CompilerServices;
using LlvmLibC.Helpers;

namespace LlvmLibC.Intrinsics.Unimplemented;

[MangledName("llvm.rint.f32")]
[DemangledName("llvm.rint.f32")]
internal static partial class llvm_rint_f32
{
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float Invoke(float parameter_0)
	{
		throw new NotImplementedException("Unimplemented LLVM intrinsic: llvm.rint.f32");
	}
}
