using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.Intrinsics.Implemented;

internal static partial class Malloc
{
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[MangledName("malloc")]
	[DemangledName("malloc")]
	public unsafe static void* Invoke(long size)
	{
		return IntrinsicFunctions.Alloc(size);
	}
}
