using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_12syscall_implIjJEEET_lDpT0_")]
[DemangledName("unsigned int __llvm_libc_20_1_2_::syscall_impl<unsigned int>(long)")]
internal static partial class unsigned_int_syscall_impl_unsigned_int_long
{
	public unsafe static int Invoke([MangledName("__number")] long number)
	{
		long num = 0L;
		llvm_lifetime_start_p0.Invoke(8L, &num);
		num = syscall_impl_long.Invoke(number);
		int result = unsigned_int_cpp_bit_or_static_cast_unsigned_int_long_long_const.Invoke(&num);
		llvm_lifetime_end_p0.Invoke(8L, &num);
		return result;
	}
}
