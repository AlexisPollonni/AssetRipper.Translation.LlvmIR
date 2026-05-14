using System;
using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.Intrinsics.Implemented;

[MangledName("llvm.maxnum.f16")]
[DemangledName("llvm.maxnum.f16")]
internal static partial class llvm_maxnum_f16
{
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Half Invoke(Half parameter_0, Half parameter_1)
	{
		return NumericHelper.MaxNum(parameter_0, parameter_1);
	}
}
