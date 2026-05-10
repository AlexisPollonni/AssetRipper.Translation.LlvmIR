using System.Runtime.CompilerServices;
using LlvmLibC.Helpers;

namespace LlvmLibC.Intrinsics.Implemented;

[MangledName("llvm.x86.sse2.pause")]
[DemangledName("llvm.x86.sse2.pause")]
internal static partial class llvm_x86_sse2_pause
{
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void Invoke()
	{
		IntrinsicFunctions.Sse2Pause();
	}
}
