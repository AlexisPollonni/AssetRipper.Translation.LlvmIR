using System;
using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.Intrinsics.Unimplemented;

[MangledName("__libc_current_sigrtmax")]
[DemangledName("__libc_current_sigrtmax")]
internal static partial class libc_current_sigrtmax
{
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static int Invoke()
	{
		throw new NotImplementedException("Unimplemented LLVM intrinsic: __libc_current_sigrtmax");
	}
}
