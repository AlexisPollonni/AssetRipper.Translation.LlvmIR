using System;
using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.Intrinsics.Implemented;

internal static partial class Llvm_minnum_f16
{
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[MangledName("llvm.minnum.f16")]
	[DemangledName("llvm.minnum.f16")]
	public static Half Invoke(Half parameter_0, Half parameter_1)
	{
		return NumericHelper.MinNum(parameter_0, parameter_1);
	}
}
