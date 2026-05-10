using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_12syscall_implIiJP7utsnameEEET_lDpT0_")]
[DemangledName("int __llvm_libc_20_1_2_::syscall_impl<int, utsname*>(long, utsname*)")]
internal static partial class int_syscall_impl_int_utsname_long_utsname
{
	public unsafe static int Invoke([MangledName("__number")] long number, void* ts)
	{
		long num = 0L;
		llvm_lifetime_start_p0.Invoke(8L, &num);
		num = syscall_impl_long_long.Invoke(number, unchecked((long)ts));
		int result = int_cpp_bit_or_static_cast_int_long_long_const.Invoke(&num);
		llvm_lifetime_end_p0.Invoke(8L, &num);
		return result;
	}
}
