using System.Runtime.CompilerServices;
using LlvmLibC.Helpers;

namespace LlvmLibC.Intrinsics.Implemented;

internal static partial class malloc
{
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public unsafe static void* Invoke(long size)
	{
		return IntrinsicFunctions.Alloc(size);
	}
}
