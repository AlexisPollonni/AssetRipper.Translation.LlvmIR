using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.Intrinsics.Implemented;

internal static partial class Ungetc
{
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[MangledName("ungetc")]
	[DemangledName("ungetc")]
	public unsafe static int Invoke(int c, void* file)
	{
		return IntrinsicFunctions.ungetc(c, file);
	}
}
