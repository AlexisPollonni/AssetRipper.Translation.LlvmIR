using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;

namespace LlvmLibC.Intrinsics.Implemented;

internal static partial class ungetc
{
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public unsafe static int Invoke(int c, void* file)
	{
		return IntrinsicFunctions.ungetc(c, file);
	}
}
