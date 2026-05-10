using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_12syscall_implIlJPcmiEEET_lDpT0_")]
[DemangledName("long __llvm_libc_20_1_2_::syscall_impl<long, char*, unsigned long, int>(long, char*, unsigned long, int)")]
internal static partial class long_syscall_impl_long_char_unsigned_long_int_long_char_unsigned_long_int
{
	public unsafe static long Invoke([MangledName("__number")] long number, [MangledName("ts")][CleanName("ts")] void* ts_3enpke, [MangledName("ts1")][CleanName("ts")] long ts_76xnpk, [MangledName("ts3")][CleanName("ts")] int ts_w24gdx)
	{
		long num = 0L;
		llvm_lifetime_start_p0.Invoke(8L, &num);
		num = syscall_impl_long_long_long_long.Invoke(number, unchecked((long)ts_3enpke), ts_76xnpk, ts_w24gdx);
		long result = long_cpp_bit_or_static_cast_long_long_long_const.Invoke(&num);
		llvm_lifetime_end_p0.Invoke(8L, &num);
		return result;
	}
}
