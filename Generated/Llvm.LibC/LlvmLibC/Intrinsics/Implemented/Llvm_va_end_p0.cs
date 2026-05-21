using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.Intrinsics.Implemented;

internal static partial class Llvm_va_end_p0
{
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[MangledName("llvm.va_end.p0")]
	[DemangledName("llvm.va_end.p0")]
	public unsafe static void Invoke(void* va_list)
	{
		IntrinsicFunctions.llvm_va_end(unchecked((void**)va_list));
	}
}
