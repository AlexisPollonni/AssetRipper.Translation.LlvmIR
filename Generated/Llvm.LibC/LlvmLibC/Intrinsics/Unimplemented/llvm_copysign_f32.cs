using System;
using System.Runtime.CompilerServices;
using LlvmLibC.Helpers;

namespace LlvmLibC.Intrinsics.Unimplemented;

[MangledName("llvm.copysign.f32")]
[DemangledName("llvm.copysign.f32")]
internal static partial class llvm_copysign_f32
{
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float Invoke(float parameter_0, float parameter_1)
	{
		throw new NotImplementedException("Unimplemented LLVM intrinsic: llvm.copysign.f32");
	}
}
