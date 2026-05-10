using System.Runtime.CompilerServices;
using LlvmLibC.Helpers;

namespace LlvmLibC.Intrinsics.Unimplemented;

[MangledName("__libc_current_sigrtmin")]
[DemangledName("__libc_current_sigrtmin")]
internal static partial class libc_current_sigrtmin
{
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static int Invoke()
	{
		throw null;
	}
}
