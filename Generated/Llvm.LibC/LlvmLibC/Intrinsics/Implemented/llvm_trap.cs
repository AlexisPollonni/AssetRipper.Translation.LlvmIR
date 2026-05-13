using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.Intrinsics.Implemented;

[MangledName("llvm.trap")]
[DemangledName("llvm.trap")]
internal static partial class llvm_trap
{
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void Invoke()
	{
		IntrinsicFunctions.Terminate();
	}
}
