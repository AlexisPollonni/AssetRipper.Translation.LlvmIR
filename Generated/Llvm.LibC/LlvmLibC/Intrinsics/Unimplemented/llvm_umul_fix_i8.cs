using System;
using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.Intrinsics.Unimplemented;

[MangledName("llvm.umul.fix.i8")]
[DemangledName("llvm.umul.fix.i8")]
internal static partial class llvm_umul_fix_i8
{
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static sbyte Invoke(sbyte parameter_0, sbyte parameter_1, int parameter_2)
	{
		throw new NotImplementedException("Unimplemented LLVM intrinsic: llvm.umul.fix.i8");
	}
}
