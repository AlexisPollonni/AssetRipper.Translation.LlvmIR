using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.Intrinsics.Implemented;

[MangledName("__errno_location")]
[DemangledName("__errno_location")]
internal static partial class errno_location
{
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public unsafe static void* Invoke()
	{
		return IntrinsicFunctions.ErrnoLocation();
	}
}
