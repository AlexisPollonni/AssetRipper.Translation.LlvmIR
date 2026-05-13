using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;

namespace LlvmLibC.Intrinsics.Implemented;

internal static partial class free
{
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public unsafe static void Invoke(void* ptr)
	{
		IntrinsicFunctions.Free(ptr);
	}
}
