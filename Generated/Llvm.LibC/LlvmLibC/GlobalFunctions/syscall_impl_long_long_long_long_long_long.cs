using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_12syscall_implEllllll")]
[DemangledName("__llvm_libc_20_1_2_::syscall_impl(long, long, long, long, long, long)")]
internal static partial class syscall_impl_long_long_long_long_long_long
{
	public unsafe static long Invoke([MangledName("__number")] long number, [MangledName("__arg1")] long arg1, [MangledName("__arg2")] long arg2, [MangledName("__arg3")] long arg3, [MangledName("__arg4")] long arg4, [MangledName("__arg5")] long arg5)
	{
		long num = 0L;
		long a = 0L;
		long a2 = 0L;
		llvm_lifetime_start_p0.Invoke(8L, &num);
		num = -6148914691236517206L;
		llvm_lifetime_start_p0.Invoke(8L, &a);
		a = arg4;
		llvm_lifetime_start_p0.Invoke(8L, &a2);
		a2 = arg5;
		num = IntrinsicFunctions.SyscallN6(number, arg1, arg2, arg3, a, a2);
		long result = num;
		llvm_lifetime_end_p0.Invoke(8L, &a2);
		llvm_lifetime_end_p0.Invoke(8L, &a);
		llvm_lifetime_end_p0.Invoke(8L, &num);
		return result;
	}
}
