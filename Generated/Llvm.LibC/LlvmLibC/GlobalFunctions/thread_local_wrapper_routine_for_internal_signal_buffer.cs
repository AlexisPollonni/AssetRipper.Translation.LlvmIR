using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Unimplemented;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZTWN19__llvm_libc_20_1_2_8internal13signal_bufferE")]
[DemangledName("thread-local wrapper routine for __llvm_libc_20_1_2_::internal::signal_buffer")]
internal static partial class thread_local_wrapper_routine_for_internal_signal_buffer
{
	public unsafe static void* Invoke()
	{
		return llvm_threadlocal_address_p0.Invoke(internal_signal_buffer.Pointer);
	}
}
