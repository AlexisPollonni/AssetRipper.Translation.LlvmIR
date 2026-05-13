using System;
using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.Intrinsics.Unimplemented;

[MangledName("llvm.trunc.f64")]
[DemangledName("llvm.trunc.f64")]
internal static partial class llvm_trunc_f64
{
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static double Invoke(double parameter_0)
	{
		throw new NotImplementedException("Unimplemented LLVM intrinsic: llvm.trunc.f64");
	}
}
