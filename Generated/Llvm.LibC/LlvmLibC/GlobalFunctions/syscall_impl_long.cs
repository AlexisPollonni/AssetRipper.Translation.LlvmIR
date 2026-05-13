using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_12syscall_implEl")]
[DemangledName("__llvm_libc_20_1_2_::syscall_impl(long)")]
internal static partial class syscall_impl_long
{
	public unsafe static long Invoke([MangledName("__number")] long number)
	{
		long num = 0L;
		llvm_lifetime_start_p0.Invoke(8L, &num);
		num = -6148914691236517206L;
		num = IntrinsicFunctions.SyscallN1(number);
		long result = num;
		llvm_lifetime_end_p0.Invoke(8L, &num);
		return result;
	}
}
