using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class syscall_impl_int_long
{
	[MangledName("_ZN19__llvm_libc_20_1_2_12syscall_implIiJlEEET_lDpT0_")]
	[DemangledName("int __llvm_libc_20_1_2_::syscall_impl<int, long>(long, long)")]
	[return: NativeType("int")]
	public unsafe static int Invoke([MangledName("__number")][NativeType("long")] long number, [NativeType("long")] long ts)
	{
		long num = 0L;
		llvm_lifetime_start_p0.Invoke(8L, &num);
		num = syscall_impl.Invoke(number, ts);
		int result = cpp_bit_or_static_cast_int_long.Invoke(&num);
		llvm_lifetime_end_p0.Invoke(8L, &num);
		return result;
	}
}
