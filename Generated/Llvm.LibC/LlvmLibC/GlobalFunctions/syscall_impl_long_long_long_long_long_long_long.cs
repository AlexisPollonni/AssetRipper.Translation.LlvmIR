using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_12syscall_implElllllll")]
[DemangledName("__llvm_libc_20_1_2_::syscall_impl(long, long, long, long, long, long, long)")]
internal static partial class syscall_impl_long_long_long_long_long_long_long
{
	public unsafe static long Invoke([MangledName("__number")] long number, [MangledName("__arg1")] long arg1, [MangledName("__arg2")] long arg2, [MangledName("__arg3")] long arg3, [MangledName("__arg4")] long arg4, [MangledName("__arg5")] long arg5, [MangledName("__arg6")] long arg6)
	{
		long num = 0L;
		long num2 = 0L;
		long num3 = 0L;
		long num4 = 0L;
		llvm_lifetime_start_p0.Invoke(8L, &num);
		num = -6148914691236517206L;
		llvm_lifetime_start_p0.Invoke(8L, &num2);
		num2 = arg4;
		llvm_lifetime_start_p0.Invoke(8L, &num3);
		num3 = arg5;
		llvm_lifetime_start_p0.Invoke(8L, &num4);
		num4 = arg6;
		num = AssemblyFunctions.M17(number, arg1, arg2, arg3, num2, num3, num4);
		long result = num;
		llvm_lifetime_end_p0.Invoke(8L, &num4);
		llvm_lifetime_end_p0.Invoke(8L, &num3);
		llvm_lifetime_end_p0.Invoke(8L, &num2);
		llvm_lifetime_end_p0.Invoke(8L, &num);
		return result;
	}
}
