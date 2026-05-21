using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.Intrinsics.Implemented;

internal static partial class Fwrite_unlocked
{
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[MangledName("fwrite_unlocked")]
	[DemangledName("fwrite_unlocked")]
	public unsafe static long Invoke(void* buf, long size, long count, void* file)
	{
		return IntrinsicFunctions.fwrite_unlocked(buf, size, count, file);
	}
}
