using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.Intrinsics.Implemented;

[MangledName("__libc_current_sigrtmax")]
[DemangledName("__libc_current_sigrtmax")]
internal static partial class libc_current_sigrtmax
{
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static int Invoke()
	{
		return IntrinsicFunctions.LibcCurrentSigRtMax();
	}
}
