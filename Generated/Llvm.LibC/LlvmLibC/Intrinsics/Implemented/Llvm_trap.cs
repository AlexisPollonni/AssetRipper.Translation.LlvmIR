using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.Intrinsics.Implemented;

internal static partial class Llvm_trap
{
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[MangledName("llvm.trap")]
	[DemangledName("llvm.trap")]
	public static void Invoke()
	{
		IntrinsicFunctions.Terminate();
	}
}
