using System;
using System.Runtime.CompilerServices;
using LlvmLibC.Helpers;

namespace LlvmLibC.Intrinsics.Unimplemented;

[MangledName("llvm.roundeven.f32")]
[DemangledName("llvm.roundeven.f32")]
internal static partial class llvm_roundeven_f32
{
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float Invoke(float parameter_0)
	{
		throw new NotImplementedException("Unimplemented LLVM intrinsic: llvm.roundeven.f32");
	}
}
