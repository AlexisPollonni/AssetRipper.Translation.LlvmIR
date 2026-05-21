using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.Intrinsics.Implemented;

internal static partial class Libc_current_sigrtmax
{
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[MangledName("__libc_current_sigrtmax")]
	[DemangledName("__libc_current_sigrtmax")]
	public static int Invoke()
	{
		return IntrinsicFunctions.LibcCurrentSigRtMax();
	}
}
