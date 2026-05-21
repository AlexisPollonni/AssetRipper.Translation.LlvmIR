using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.Intrinsics.Implemented;

internal static partial class Realloc
{
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[MangledName("realloc")]
	[DemangledName("realloc")]
	public unsafe static void* Invoke(void* ptr, long size)
	{
		return IntrinsicFunctions.ReAlloc(ptr, size);
	}
}
