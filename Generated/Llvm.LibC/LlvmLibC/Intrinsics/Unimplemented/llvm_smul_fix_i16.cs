using System;
using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.Intrinsics.Unimplemented;

[MangledName("llvm.smul.fix.i16")]
[DemangledName("llvm.smul.fix.i16")]
internal static partial class llvm_smul_fix_i16
{
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static short Invoke(short parameter_0, short parameter_1, int parameter_2)
	{
		throw new NotImplementedException("Unimplemented LLVM intrinsic: llvm.smul.fix.i16");
	}
}
