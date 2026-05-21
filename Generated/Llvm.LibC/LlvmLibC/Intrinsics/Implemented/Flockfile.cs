using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.Intrinsics.Implemented;

internal static partial class Flockfile
{
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[MangledName("flockfile")]
	[DemangledName("flockfile")]
	public unsafe static void Invoke(void* file)
	{
		IntrinsicFunctions.flockfile(file);
	}
}
