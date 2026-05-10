using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_12syscall_implIlJPNS_5FutexEiiDnDniEEET_lDpT0_")]
[DemangledName("long __llvm_libc_20_1_2_::syscall_impl<long, __llvm_libc_20_1_2_::Futex*, int, int, std::nullptr_t, std::nullptr_t, int>(long, __llvm_libc_20_1_2_::Futex*, int, int, std::nullptr_t, std::nullptr_t, int)")]
internal static partial class long_syscall_impl_long_Futex_int_int_std_nullptr_t_std_nullptr_t_int_long_Futex_int_int_std_nullptr_t_std_nullptr_t_int
{
	public unsafe static long Invoke([MangledName("__number")] long number, [MangledName("ts")][CleanName("ts")] void* ts_3enpke, [MangledName("ts1")][CleanName("ts")] int ts_76xnpk, [MangledName("ts3")][CleanName("ts")] int ts_w24gdx, [MangledName("ts5")][CleanName("ts")] void* ts_784yyq, [MangledName("ts7")][CleanName("ts")] void* ts_4jbuhx, [MangledName("ts9")][CleanName("ts")] int ts_g7c8gc)
	{
		long num = 0L;
		llvm_lifetime_start_p0.Invoke(8L, &num);
		num = syscall_impl_long_long_long_long_long_long_long.Invoke(number, unchecked((long)ts_3enpke), ts_76xnpk, ts_w24gdx, 0L, 0L, ts_g7c8gc);
		long result = long_cpp_bit_or_static_cast_long_long_long_const.Invoke(&num);
		llvm_lifetime_end_p0.Invoke(8L, &num);
		return result;
	}
}
