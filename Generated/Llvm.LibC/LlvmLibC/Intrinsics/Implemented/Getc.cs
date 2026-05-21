using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.Intrinsics.Implemented;

internal static partial class Getc
{
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[MangledName("getc")]
	[DemangledName("getc")]
	public unsafe static int Invoke(void* file)
	{
		return IntrinsicFunctions.FGetc(file);
	}
}
