using System;
using System.Runtime.CompilerServices;
using LlvmLibC.Helpers;

namespace LlvmLibC.Intrinsics.Implemented;

[MangledName("llvm.cttz.i128")]
[DemangledName("llvm.cttz.i128")]
internal static partial class llvm_cttz_i128
{
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Int128 Invoke(Int128 parameter_0, bool parameter_1)
	{
		return NumericHelper.CtTz(parameter_0);
	}
}
