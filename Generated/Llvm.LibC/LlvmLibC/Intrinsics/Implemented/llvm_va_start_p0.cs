using System.Runtime.CompilerServices;
using LlvmLibC.Helpers;

namespace LlvmLibC.Intrinsics.Implemented;

[MangledName("llvm.va_start.p0")]
[DemangledName("llvm.va_start.p0")]
internal static partial class llvm_va_start_p0
{
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public unsafe static void Invoke(void* va_list)
	{
		IntrinsicFunctions.llvm_va_start(unchecked((void**)va_list));
	}
}
