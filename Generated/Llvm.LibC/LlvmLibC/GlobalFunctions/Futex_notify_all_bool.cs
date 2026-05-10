using LlvmLibC.Helpers;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_5Futex10notify_allEb")]
[DemangledName("__llvm_libc_20_1_2_::Futex::notify_all(bool)")]
internal static partial class Futex_notify_all_bool
{
	public unsafe static long Invoke(void* @this, bool is_shared)
	{
		return long_syscall_impl_long_Futex_int_int_std_nullptr_t_std_nullptr_t_int_long_Futex_int_int_std_nullptr_t_std_nullptr_t_int.Invoke(202L, @this, InstructionHelper.Select(((is_shared ? 1u : 0u) & 1u) == 1, 1, 129), cpp_internal_integer_impl_int_2147483648_2147483647_max.Invoke(), null, null, 0);
	}
}
