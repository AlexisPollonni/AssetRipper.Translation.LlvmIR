using System;
using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.Intrinsics.Unimplemented;

[MangledName("llvm.roundeven.f64")]
[DemangledName("llvm.roundeven.f64")]
internal static partial class llvm_roundeven_f64
{
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static double Invoke(double parameter_0)
	{
		throw new NotImplementedException("Unimplemented LLVM intrinsic: llvm.roundeven.f64");
	}
}
