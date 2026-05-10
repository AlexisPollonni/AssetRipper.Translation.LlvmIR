using System.Runtime.CompilerServices;
using LlvmLibC.Helpers;

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
