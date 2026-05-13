using System;
using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.Intrinsics.Unimplemented;

[MangledName("llvm.fma.f64")]
[DemangledName("llvm.fma.f64")]
internal static partial class llvm_fma_f64
{
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static double Invoke(double parameter_0, double parameter_1, double parameter_2)
	{
		throw new NotImplementedException("Unimplemented LLVM intrinsic: llvm.fma.f64");
	}
}
