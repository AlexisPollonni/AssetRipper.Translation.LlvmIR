using System.Runtime.CompilerServices;
using LlvmLibC.Helpers;

namespace LlvmLibC.Intrinsics.Unimplemented;

[MangledName("__libc_current_sigrtmax")]
[DemangledName("__libc_current_sigrtmax")]
internal static partial class libc_current_sigrtmax
{
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static int Invoke()
	{
		throw null;
	}
}
