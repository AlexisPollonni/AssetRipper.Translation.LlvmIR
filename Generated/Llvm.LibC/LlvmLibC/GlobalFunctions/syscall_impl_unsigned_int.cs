using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class syscall_impl_unsigned_int
{
	[MangledName("_ZN19__llvm_libc_20_1_2_12syscall_implIjJEEET_lDpT0_")]
	[DemangledName("unsigned int __llvm_libc_20_1_2_::syscall_impl<unsigned int>(long)")]
	[return: NativeType("unsigned int")]
	public unsafe static int Invoke([MangledName("__number")][NativeType("long")] long number)
	{
		long num = 0L;
		llvm_lifetime_start_p0.Invoke(8L, &num);
		num = syscall_impl.Invoke(number);
		int result = cpp_bit_or_static_cast_unsigned_int_long.Invoke(&num);
		llvm_lifetime_end_p0.Invoke(8L, &num);
		return result;
	}
}
