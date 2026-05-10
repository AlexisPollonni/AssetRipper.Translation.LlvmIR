using System;
using System.Runtime.CompilerServices;
using LlvmLibC.Helpers;

namespace LlvmLibC.Intrinsics.Implemented;

[MangledName("llvm.fabs.f16")]
[DemangledName("llvm.fabs.f16")]
internal static partial class llvm_fabs_f16
{
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Half Invoke(Half parameter_0)
	{
		return NumericHelper.FAbs(parameter_0);
	}
}
