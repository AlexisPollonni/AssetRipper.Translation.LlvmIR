using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_12syscall_implIiJiiPiEEET_lDpT0_")]
[DemangledName("int __llvm_libc_20_1_2_::syscall_impl<int, int, int, int*>(long, int, int, int*)")]
[CleanName("int_syscall_impl_int_int_int_int_long_int_int_int")]
internal static partial class int_syscall_impl_int_int_int_int_long_int_int_int_zzjp7j
{
	public unsafe static int Invoke([MangledName("__number")] long number, [MangledName("ts")][CleanName("ts")] int ts_3enpke, [MangledName("ts1")][CleanName("ts")] int ts_76xnpk, [MangledName("ts3")][CleanName("ts")] void* ts_w24gdx)
	{
		long num = 0L;
		llvm_lifetime_start_p0.Invoke(8L, &num);
		num = syscall_impl_long_long_long_long.Invoke(number, ts_3enpke, ts_76xnpk, unchecked((long)ts_w24gdx));
		int result = int_cpp_bit_or_static_cast_int_long_long_const.Invoke(&num);
		llvm_lifetime_end_p0.Invoke(8L, &num);
		return result;
	}
}
