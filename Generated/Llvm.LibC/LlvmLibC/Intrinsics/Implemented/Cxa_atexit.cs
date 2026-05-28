using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.Intrinsics.Implemented;

internal static partial class Cxa_atexit
{
	public unsafe static readonly void* __pointer = (delegate*<void*, void*, void*, int>)(&Invoke);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[MangledName("__cxa_atexit")]
	[DemangledName("__cxa_atexit")]
	public unsafe static int Invoke(void* func, void* arg, void* dsoHandle)
	{
		return IntrinsicFunctions.CxaAtexit(unchecked((delegate*<void*, void>)func), arg, dsoHandle);
	}
}
