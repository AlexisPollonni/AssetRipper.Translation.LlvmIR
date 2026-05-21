using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.Intrinsics.Implemented;

internal static partial class Funlockfile
{
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[MangledName("funlockfile")]
	[DemangledName("funlockfile")]
	public unsafe static void Invoke(void* file)
	{
		IntrinsicFunctions.funlockfile(file);
	}
}
