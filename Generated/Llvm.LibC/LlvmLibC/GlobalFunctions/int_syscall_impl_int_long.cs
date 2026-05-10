using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_12syscall_implIiJEEET_lDpT0_")]
[DemangledName("int __llvm_libc_20_1_2_::syscall_impl<int>(long)")]
internal static partial class int_syscall_impl_int_long
{
	public unsafe static int Invoke([MangledName("__number")] long number)
	{
		long num = 0L;
		llvm_lifetime_start_p0.Invoke(8L, &num);
		num = syscall_impl_long.Invoke(number);
		int result = int_cpp_bit_or_static_cast_int_long_long_const.Invoke(&num);
		llvm_lifetime_end_p0.Invoke(8L, &num);
		return result;
	}
}
