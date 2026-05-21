using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class thread_local_wrapper_routine_for_internal_error_buffer
{
	[MangledName("_ZTWN19__llvm_libc_20_1_2_8internal12error_bufferE")]
	[DemangledName("thread-local wrapper routine for __llvm_libc_20_1_2_::internal::error_buffer")]
	public unsafe static void* Invoke()
	{
		return llvm_threadlocal_address_p0.Invoke(internal_error_buffer.Pointer);
	}
}
