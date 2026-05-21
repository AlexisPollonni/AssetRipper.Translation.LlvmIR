using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class syscall_impl
{
	[MangledName("_ZN19__llvm_libc_20_1_2_12syscall_implEl")]
	[DemangledName("__llvm_libc_20_1_2_::syscall_impl(long)")]
	public unsafe static long Invoke([MangledName("__number")][NativeType("long")] long number)
	{
		long num = 0L;
		llvm_lifetime_start_p0.Invoke(8L, &num);
		num = -6148914691236517206L;
		num = IntrinsicFunctions.SyscallN1(number);
		long result = num;
		llvm_lifetime_end_p0.Invoke(8L, &num);
		return result;
	}

	[MangledName("_ZN19__llvm_libc_20_1_2_12syscall_implEll")]
	[DemangledName("__llvm_libc_20_1_2_::syscall_impl(long, long)")]
	public unsafe static long Invoke([MangledName("__number")][NativeType("long")] long number, [MangledName("__arg1")][NativeType("long")] long arg1)
	{
		long num = 0L;
		llvm_lifetime_start_p0.Invoke(8L, &num);
		num = -6148914691236517206L;
		num = IntrinsicFunctions.SyscallN2(number, arg1);
		long result = num;
		llvm_lifetime_end_p0.Invoke(8L, &num);
		return result;
	}

	[MangledName("_ZN19__llvm_libc_20_1_2_12syscall_implElll")]
	[DemangledName("__llvm_libc_20_1_2_::syscall_impl(long, long, long)")]
	public unsafe static long Invoke([MangledName("__number")][NativeType("long")] long number, [MangledName("__arg1")][NativeType("long")] long arg1, [MangledName("__arg2")][NativeType("long")] long arg2)
	{
		long num = 0L;
		llvm_lifetime_start_p0.Invoke(8L, &num);
		num = -6148914691236517206L;
		num = IntrinsicFunctions.SyscallN3(number, arg1, arg2);
		long result = num;
		llvm_lifetime_end_p0.Invoke(8L, &num);
		return result;
	}

	[MangledName("_ZN19__llvm_libc_20_1_2_12syscall_implEllll")]
	[DemangledName("__llvm_libc_20_1_2_::syscall_impl(long, long, long, long)")]
	public unsafe static long Invoke([MangledName("__number")][NativeType("long")] long number, [MangledName("__arg1")][NativeType("long")] long arg1, [MangledName("__arg2")][NativeType("long")] long arg2, [MangledName("__arg3")][NativeType("long")] long arg3)
	{
		long num = 0L;
		llvm_lifetime_start_p0.Invoke(8L, &num);
		num = -6148914691236517206L;
		num = IntrinsicFunctions.SyscallN4(number, arg1, arg2, arg3);
		long result = num;
		llvm_lifetime_end_p0.Invoke(8L, &num);
		return result;
	}

	[MangledName("_ZN19__llvm_libc_20_1_2_12syscall_implElllll")]
	[DemangledName("__llvm_libc_20_1_2_::syscall_impl(long, long, long, long, long)")]
	public unsafe static long Invoke([MangledName("__number")][NativeType("long")] long number, [MangledName("__arg1")][NativeType("long")] long arg1, [MangledName("__arg2")][NativeType("long")] long arg2, [MangledName("__arg3")][NativeType("long")] long arg3, [MangledName("__arg4")][NativeType("long")] long arg4)
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

	[MangledName("_ZN19__llvm_libc_20_1_2_12syscall_implEllllll")]
	[DemangledName("__llvm_libc_20_1_2_::syscall_impl(long, long, long, long, long, long)")]
	public unsafe static long Invoke([MangledName("__number")][NativeType("long")] long number, [MangledName("__arg1")][NativeType("long")] long arg1, [MangledName("__arg2")][NativeType("long")] long arg2, [MangledName("__arg3")][NativeType("long")] long arg3, [MangledName("__arg4")][NativeType("long")] long arg4, [MangledName("__arg5")][NativeType("long")] long arg5)
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

	[MangledName("_ZN19__llvm_libc_20_1_2_12syscall_implElllllll")]
	[DemangledName("__llvm_libc_20_1_2_::syscall_impl(long, long, long, long, long, long, long)")]
	public unsafe static long Invoke([MangledName("__number")][NativeType("long")] long number, [MangledName("__arg1")][NativeType("long")] long arg1, [MangledName("__arg2")][NativeType("long")] long arg2, [MangledName("__arg3")][NativeType("long")] long arg3, [MangledName("__arg4")][NativeType("long")] long arg4, [MangledName("__arg5")][NativeType("long")] long arg5, [MangledName("__arg6")][NativeType("long")] long arg6)
	{
		long num = 0L;
		long a = 0L;
		long a2 = 0L;
		long a3 = 0L;
		llvm_lifetime_start_p0.Invoke(8L, &num);
		num = -6148914691236517206L;
		llvm_lifetime_start_p0.Invoke(8L, &a);
		a = arg4;
		llvm_lifetime_start_p0.Invoke(8L, &a2);
		a2 = arg5;
		llvm_lifetime_start_p0.Invoke(8L, &a3);
		a3 = arg6;
		num = IntrinsicFunctions.DotnetSyscall(number, arg1, arg2, arg3, a, a2, a3);
		long result = num;
		llvm_lifetime_end_p0.Invoke(8L, &a3);
		llvm_lifetime_end_p0.Invoke(8L, &a2);
		llvm_lifetime_end_p0.Invoke(8L, &a);
		llvm_lifetime_end_p0.Invoke(8L, &num);
		return result;
	}
}
