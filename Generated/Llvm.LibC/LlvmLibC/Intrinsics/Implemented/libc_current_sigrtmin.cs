using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.Intrinsics.Implemented;

internal static partial class libc_current_sigrtmin
{
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[MangledName("__libc_current_sigrtmin")]
	[DemangledName("__libc_current_sigrtmin")]
	public static int Invoke()
	{
		return IntrinsicFunctions.LibcCurrentSigRtMin();
	}
}
