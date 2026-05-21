using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.Intrinsics.Implemented;

internal static partial class Free
{
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[MangledName("free")]
	[DemangledName("free")]
	public unsafe static void Invoke(void* ptr)
	{
		IntrinsicFunctions.Free(ptr);
	}
}
