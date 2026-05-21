using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.Intrinsics.Implemented;

internal static partial class llvm_x86_sse2_pause
{
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[MangledName("llvm.x86.sse2.pause")]
	[DemangledName("llvm.x86.sse2.pause")]
	public static void Invoke()
	{
		IntrinsicFunctions.Sse2Pause();
	}
}
