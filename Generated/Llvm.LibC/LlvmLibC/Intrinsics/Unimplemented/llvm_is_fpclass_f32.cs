using System;
using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.Intrinsics.Unimplemented;

[MangledName("llvm.is.fpclass.f32")]
[DemangledName("llvm.is.fpclass.f32")]
internal static partial class llvm_is_fpclass_f32
{
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool Invoke(float parameter_0, int parameter_1)
	{
		throw new NotImplementedException("Unimplemented LLVM intrinsic: llvm.is.fpclass.f32");
	}
}
