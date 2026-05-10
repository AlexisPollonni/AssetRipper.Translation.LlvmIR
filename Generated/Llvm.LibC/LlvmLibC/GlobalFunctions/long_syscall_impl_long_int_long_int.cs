using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_12syscall_implIlJiEEET_lDpT0_")]
[DemangledName("long __llvm_libc_20_1_2_::syscall_impl<long, int>(long, int)")]
internal static partial class long_syscall_impl_long_int_long_int
{
	public unsafe static long Invoke([MangledName("__number")] long number, int ts)
	{
		long num = 0L;
		llvm_lifetime_start_p0.Invoke(8L, &num);
		num = syscall_impl_long_long.Invoke(number, ts);
		long result = long_cpp_bit_or_static_cast_long_long_long_const.Invoke(&num);
		llvm_lifetime_end_p0.Invoke(8L, &num);
		return result;
	}
}
