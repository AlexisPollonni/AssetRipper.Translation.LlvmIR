using System;
using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.Intrinsics.Unimplemented;

[MangledName("llvm.copysign.f64")]
[DemangledName("llvm.copysign.f64")]
internal static partial class llvm_copysign_f64
{
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static double Invoke(double parameter_0, double parameter_1)
	{
		throw new NotImplementedException("Unimplemented LLVM intrinsic: llvm.copysign.f64");
	}
}
