using System;
using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.Intrinsics.Implemented;

internal static partial class llvm_fabs_f16
{
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[MangledName("llvm.fabs.f16")]
	[DemangledName("llvm.fabs.f16")]
	public static Half Invoke(Half parameter_0)
	{
		return NumericHelper.FAbs(parameter_0);
	}
}
