using System;
using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.Intrinsics.Implemented;

internal static partial class llvm_cttz_i128
{
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[MangledName("llvm.cttz.i128")]
	[DemangledName("llvm.cttz.i128")]
	public static Int128 Invoke(Int128 parameter_0, bool parameter_1)
	{
		return NumericHelper.CtTz(parameter_0);
	}
}
