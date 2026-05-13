using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;

namespace LlvmLibC.Intrinsics.Implemented;

internal static partial class getc
{
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public unsafe static int Invoke(void* file)
	{
		return IntrinsicFunctions.FGetc(file);
	}
}
