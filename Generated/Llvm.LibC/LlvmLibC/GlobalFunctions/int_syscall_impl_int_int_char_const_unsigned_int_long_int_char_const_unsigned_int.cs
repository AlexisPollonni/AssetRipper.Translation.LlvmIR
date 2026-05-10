using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_12syscall_implIiJiPKcjEEET_lDpT0_")]
[DemangledName("int __llvm_libc_20_1_2_::syscall_impl<int, int, char const*, unsigned int>(long, int, char const*, unsigned int)")]
internal static partial class int_syscall_impl_int_int_char_const_unsigned_int_long_int_char_const_unsigned_int
{
	public unsafe static int Invoke([MangledName("__number")] long number, [MangledName("ts")][CleanName("ts")] int ts_3enpke, [MangledName("ts1")][CleanName("ts")] void* ts_76xnpk, [MangledName("ts3")][CleanName("ts")] int ts_w24gdx)
	{
		long num = 0L;
		llvm_lifetime_start_p0.Invoke(8L, &num);
		num = unchecked(syscall_impl_long_long_long_long.Invoke(number, ts_3enpke, (long)ts_76xnpk, (uint)ts_w24gdx));
		int result = int_cpp_bit_or_static_cast_int_long_long_const.Invoke(&num);
		llvm_lifetime_end_p0.Invoke(8L, &num);
		return result;
	}
}
