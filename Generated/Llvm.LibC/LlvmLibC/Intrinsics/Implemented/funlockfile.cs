using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;

namespace LlvmLibC.Intrinsics.Implemented;

internal static partial class funlockfile
{
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public unsafe static void Invoke(void* file)
	{
		IntrinsicFunctions.funlockfile(file);
	}
}
