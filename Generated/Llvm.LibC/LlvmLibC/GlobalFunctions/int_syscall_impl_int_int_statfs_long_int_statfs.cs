using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_12syscall_implIiJiP6statfsEEET_lDpT0_")]
[DemangledName("int __llvm_libc_20_1_2_::syscall_impl<int, int, statfs*>(long, int, statfs*)")]
internal static partial class int_syscall_impl_int_int_statfs_long_int_statfs
{
	public unsafe static int Invoke([MangledName("__number")] long number, [MangledName("ts")][CleanName("ts")] int ts_3enpke, [MangledName("ts1")][CleanName("ts")] void* ts_76xnpk)
	{
		long num = 0L;
		llvm_lifetime_start_p0.Invoke(8L, &num);
		num = syscall_impl_long_long_long.Invoke(number, ts_3enpke, unchecked((long)ts_76xnpk));
		int result = int_cpp_bit_or_static_cast_int_long_long_const.Invoke(&num);
		llvm_lifetime_end_p0.Invoke(8L, &num);
		return result;
	}
}
