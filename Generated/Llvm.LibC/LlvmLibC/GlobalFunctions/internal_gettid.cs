using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class internal_gettid
{
	[MangledName("_ZN19__llvm_libc_20_1_2_8internal6gettidEv")]
	[DemangledName("__llvm_libc_20_1_2_::internal::gettid()")]
	public unsafe static int Invoke()
	{
		void* ptr = null;
		llvm_lifetime_start_p0.Invoke(8L, &ptr);
		ptr = internal_get_tid_cache.Invoke();
		int result = unchecked((!details_expects_bool_condition_bool.Invoke((ptr != null) ? (*(int*)ptr <= 0) : true, expected: false)) ? (*(int*)ptr) : syscall_impl_int.Invoke(186L));
		llvm_lifetime_end_p0.Invoke(8L, &ptr);
		return result;
	}
}
