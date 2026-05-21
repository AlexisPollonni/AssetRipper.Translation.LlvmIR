using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.Intrinsics.Implemented;

internal static partial class Errno_location
{
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[MangledName("__errno_location")]
	[DemangledName("__errno_location")]
	public unsafe static void* Invoke()
	{
		return IntrinsicFunctions.ErrnoLocation();
	}
}
