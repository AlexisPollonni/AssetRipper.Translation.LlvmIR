using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_12syscall_implElllll")]
[DemangledName("__llvm_libc_20_1_2_::syscall_impl(long, long, long, long, long)")]
internal static partial class syscall_impl_long_long_long_long_long
{
	public unsafe static long Invoke([MangledName("__number")] long number, [MangledName("__arg1")] long arg1, [MangledName("__arg2")] long arg2, [MangledName("__arg3")] long arg3, [MangledName("__arg4")] long arg4)
	{
		long num = 0L;
		long a = 0L;
		llvm_lifetime_start_p0.Invoke(8L, &num);
		num = -6148914691236517206L;
		llvm_lifetime_start_p0.Invoke(8L, &a);
		a = arg4;
		num = IntrinsicFunctions.SyscallN5(number, arg1, arg2, arg3, a);
		long result = num;
		llvm_lifetime_end_p0.Invoke(8L, &a);
		llvm_lifetime_end_p0.Invoke(8L, &num);
		return result;
	}
}
