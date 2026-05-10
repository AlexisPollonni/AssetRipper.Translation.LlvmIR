using System.Runtime.CompilerServices;
using LlvmLibC.Helpers;

namespace LlvmLibC.Intrinsics.Implemented;

internal static partial class realloc
{
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public unsafe static void* Invoke(void* ptr, long size)
	{
		return IntrinsicFunctions.ReAlloc(ptr, size);
	}
}
