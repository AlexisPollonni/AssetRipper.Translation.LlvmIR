using LlvmLibC.Enumerations;
using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_5Futex4waitEjNS_3cpp8optionalINS_8internal10AbsTimeoutEEEb")]
[DemangledName("__llvm_libc_20_1_2_::Futex::wait(unsigned int, __llvm_libc_20_1_2_::cpp::optional<__llvm_libc_20_1_2_::internal::AbsTimeout>, bool)")]
internal static partial class Futex_wait_unsigned_int_cpp_optional_internal_AbsTimeout_bool
{
	public unsafe static long Invoke(void* @this, int expected, void* timeout, bool is_shared)
	{
		long result = 0L;
		int num = 0;
		long num2 = 0L;
		sbyte b = (is_shared ? ((sbyte)1) : ((sbyte)0));
		llvm_lifetime_start_p0.Invoke(4L, &num);
		num = InstructionHelper.Select((b & 1) == 1, 9, 137);
		unchecked
		{
			if (cpp_optional_internal_AbsTimeout_operator_bool_const.Invoke((cpp_optional_59q3zq*)timeout) && internal_AbsTimeout_is_realtime_const.Invoke(cpp_optional_internal_AbsTimeout_operator.Invoke((cpp_optional_59q3zq*)timeout)))
			{
				num |= 0x100;
			}
			int num3;
			do
			{
				if (cpp_Atomic_unsigned_int_load_cpp_MemoryOrder_cpp_MemoryScope.Invoke(@this, MemoryOrder.RELAXED, MemoryScope.DEVICE) != expected)
				{
					result = 0L;
					break;
				}
				llvm_lifetime_start_p0.Invoke(8L, &num2);
				num2 = long_syscall_impl_long_Futex_unsigned_int_unsigned_int_timespec_const_std_nullptr_t_unsigned_int_long_Futex_unsigned_int_unsigned_int_timespec_const_std_nullptr_t_unsigned_int.Invoke(202L, @this, num, expected, (!cpp_optional_internal_AbsTimeout_operator_bool_const.Invoke((cpp_optional_59q3zq*)timeout)) ? null : internal_AbsTimeout_get_timespec_const.Invoke(cpp_optional_internal_AbsTimeout_operator.Invoke((cpp_optional_59q3zq*)timeout)), null, -1);
				if (num2 == -4L)
				{
					num3 = 3;
				}
				else
				{
					result = num2;
					num3 = 1;
				}
				llvm_lifetime_end_p0.Invoke(8L, &num2);
			}
			while (num3 == 3);
			llvm_lifetime_end_p0.Invoke(4L, &num);
			return result;
		}
	}
}
