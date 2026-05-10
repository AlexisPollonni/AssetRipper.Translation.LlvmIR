using System.Runtime.CompilerServices;
using LlvmLibC.Helpers;

namespace LlvmLibC.Intrinsics.Implemented;

[MangledName("__cxa_atexit")]
[DemangledName("__cxa_atexit")]
internal static partial class cxa_atexit
{
	public unsafe static readonly void* __pointer = PointerIndices.Register((delegate*<void*, void*, void*, int>)(&Invoke));

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public unsafe static int Invoke(void* func, void* arg, void* dsoHandle)
	{
		return IntrinsicFunctions.CxaAtexit(unchecked((delegate*<void*, void>)func), arg, dsoHandle);
	}
}
