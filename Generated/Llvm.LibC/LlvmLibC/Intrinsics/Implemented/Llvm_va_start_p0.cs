using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.Intrinsics.Implemented;

internal static partial class Llvm_va_start_p0
{
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[MangledName("llvm.va_start.p0")]
	[DemangledName("llvm.va_start.p0")]
	public unsafe static void Invoke(void* va_list)
	{
		IntrinsicFunctions.llvm_va_start(unchecked((void**)va_list));
	}
}
