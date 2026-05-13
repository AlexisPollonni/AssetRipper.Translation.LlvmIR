using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_8internal6gettidEv")]
[DemangledName("__llvm_libc_20_1_2_::internal::gettid()")]
internal static partial class internal_gettid
{
	public unsafe static int Invoke()
	{
		void* ptr = null;
		llvm_lifetime_start_p0.Invoke(8L, &ptr);
		ptr = internal_get_tid_cache.Invoke();
		int result = unchecked((!bool_details_expects_bool_condition_bool_bool_bool.Invoke((ptr != null) ? (*(int*)ptr <= 0) : true, expected: false)) ? (*(int*)ptr) : int_syscall_impl_int_long.Invoke(186L));
		llvm_lifetime_end_p0.Invoke(8L, &ptr);
		return result;
	}
}
