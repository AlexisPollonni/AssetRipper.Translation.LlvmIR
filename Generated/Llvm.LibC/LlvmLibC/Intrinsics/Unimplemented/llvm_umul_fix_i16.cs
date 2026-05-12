using System;
using System.Runtime.CompilerServices;
using LlvmLibC.Helpers;

namespace LlvmLibC.Intrinsics.Unimplemented;

[MangledName("llvm.umul.fix.i16")]
[DemangledName("llvm.umul.fix.i16")]
internal static partial class llvm_umul_fix_i16
{
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static short Invoke(short parameter_0, short parameter_1, int parameter_2)
	{
		throw new NotImplementedException("Unimplemented LLVM intrinsic: llvm.umul.fix.i16");
	}
}
