using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;

namespace LlvmLibC.Intrinsics.Implemented;

internal static partial class fwrite_unlocked
{
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public unsafe static long Invoke(void* buf, long size, long count, void* file)
	{
		return IntrinsicFunctions.fwrite_unlocked(buf, size, count, file);
	}
}
