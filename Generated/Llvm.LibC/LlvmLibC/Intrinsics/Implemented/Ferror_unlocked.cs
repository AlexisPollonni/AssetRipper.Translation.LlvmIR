using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.Intrinsics.Implemented;

internal static partial class Ferror_unlocked
{
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[MangledName("ferror_unlocked")]
	[DemangledName("ferror_unlocked")]
	public unsafe static int Invoke(void* file)
	{
		return IntrinsicFunctions.ferror_unlocked(file);
	}
}
