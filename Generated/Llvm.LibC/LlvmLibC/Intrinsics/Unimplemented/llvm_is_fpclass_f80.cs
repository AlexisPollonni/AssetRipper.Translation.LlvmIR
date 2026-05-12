using System;
using System.Runtime.CompilerServices;
using LlvmLibC.Helpers;

namespace LlvmLibC.Intrinsics.Unimplemented;

[MangledName("llvm.is.fpclass.f80")]
[DemangledName("llvm.is.fpclass.f80")]
internal static partial class llvm_is_fpclass_f80
{
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool Invoke(double parameter_0, int parameter_1)
	{
		throw new NotImplementedException("Unimplemented LLVM intrinsic: llvm.is.fpclass.f80");
	}
}
