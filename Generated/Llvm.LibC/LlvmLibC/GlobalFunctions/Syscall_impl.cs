using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Syscall_impl
{
	[MangledName("_ZN19__llvm_libc_20_1_2_12syscall_implEl")]
	[DemangledName("__llvm_libc_20_1_2_::syscall_impl(long)")]
	public unsafe static long Invoke([MangledName("__number")][NativeType("long")] long Number)
	{
		long num = 0L;
		Llvm_lifetime_start_p0.Invoke(8L, &num);
		num = -6148914691236517206L;
		num = IntrinsicFunctions.SyscallN1(Number);
		long result = num;
		Llvm_lifetime_end_p0.Invoke(8L, &num);
		return result;
	}

	[MangledName("_ZN19__llvm_libc_20_1_2_12syscall_implEll")]
	[DemangledName("__llvm_libc_20_1_2_::syscall_impl(long, long)")]
	public unsafe static long Invoke([MangledName("__number")][NativeType("long")] long Number, [MangledName("__arg1")][NativeType("long")] long Arg1)
	{
		long num = 0L;
		Llvm_lifetime_start_p0.Invoke(8L, &num);
		num = -6148914691236517206L;
		num = IntrinsicFunctions.SyscallN2(Number, Arg1);
		long result = num;
		Llvm_lifetime_end_p0.Invoke(8L, &num);
		return result;
	}

	[MangledName("_ZN19__llvm_libc_20_1_2_12syscall_implElll")]
	[DemangledName("__llvm_libc_20_1_2_::syscall_impl(long, long, long)")]
	public unsafe static long Invoke([MangledName("__number")][NativeType("long")] long Number, [MangledName("__arg1")][NativeType("long")] long Arg1, [MangledName("__arg2")][NativeType("long")] long Arg2)
	{
		long num = 0L;
		Llvm_lifetime_start_p0.Invoke(8L, &num);
		num = -6148914691236517206L;
		num = IntrinsicFunctions.SyscallN3(Number, Arg1, Arg2);
		long result = num;
		Llvm_lifetime_end_p0.Invoke(8L, &num);
		return result;
	}

	[MangledName("_ZN19__llvm_libc_20_1_2_12syscall_implEllll")]
	[DemangledName("__llvm_libc_20_1_2_::syscall_impl(long, long, long, long)")]
	public unsafe static long Invoke([MangledName("__number")][NativeType("long")] long Number, [MangledName("__arg1")][NativeType("long")] long Arg1, [MangledName("__arg2")][NativeType("long")] long Arg2, [MangledName("__arg3")][NativeType("long")] long Arg3)
	{
		long num = 0L;
		Llvm_lifetime_start_p0.Invoke(8L, &num);
		num = -6148914691236517206L;
		num = IntrinsicFunctions.SyscallN4(Number, Arg1, Arg2, Arg3);
		long result = num;
		Llvm_lifetime_end_p0.Invoke(8L, &num);
		return result;
	}

	[MangledName("_ZN19__llvm_libc_20_1_2_12syscall_implElllll")]
	[DemangledName("__llvm_libc_20_1_2_::syscall_impl(long, long, long, long, long)")]
	public unsafe static long Invoke([MangledName("__number")][NativeType("long")] long Number, [MangledName("__arg1")][NativeType("long")] long Arg1, [MangledName("__arg2")][NativeType("long")] long Arg2, [MangledName("__arg3")][NativeType("long")] long Arg3, [MangledName("__arg4")][NativeType("long")] long Arg4)
	{
		long num = 0L;
		long a = 0L;
		Llvm_lifetime_start_p0.Invoke(8L, &num);
		num = -6148914691236517206L;
		Llvm_lifetime_start_p0.Invoke(8L, &a);
		a = Arg4;
		num = IntrinsicFunctions.SyscallN5(Number, Arg1, Arg2, Arg3, a);
		long result = num;
		Llvm_lifetime_end_p0.Invoke(8L, &a);
		Llvm_lifetime_end_p0.Invoke(8L, &num);
		return result;
	}

	[MangledName("_ZN19__llvm_libc_20_1_2_12syscall_implEllllll")]
	[DemangledName("__llvm_libc_20_1_2_::syscall_impl(long, long, long, long, long, long)")]
	public unsafe static long Invoke([MangledName("__number")][NativeType("long")] long Number, [MangledName("__arg1")][NativeType("long")] long Arg1, [MangledName("__arg2")][NativeType("long")] long Arg2, [MangledName("__arg3")][NativeType("long")] long Arg3, [MangledName("__arg4")][NativeType("long")] long Arg4, [MangledName("__arg5")][NativeType("long")] long Arg5)
	{
		long num = 0L;
		long a = 0L;
		long a2 = 0L;
		Llvm_lifetime_start_p0.Invoke(8L, &num);
		num = -6148914691236517206L;
		Llvm_lifetime_start_p0.Invoke(8L, &a);
		a = Arg4;
		Llvm_lifetime_start_p0.Invoke(8L, &a2);
		a2 = Arg5;
		num = IntrinsicFunctions.SyscallN6(Number, Arg1, Arg2, Arg3, a, a2);
		long result = num;
		Llvm_lifetime_end_p0.Invoke(8L, &a2);
		Llvm_lifetime_end_p0.Invoke(8L, &a);
		Llvm_lifetime_end_p0.Invoke(8L, &num);
		return result;
	}

	[MangledName("_ZN19__llvm_libc_20_1_2_12syscall_implElllllll")]
	[DemangledName("__llvm_libc_20_1_2_::syscall_impl(long, long, long, long, long, long, long)")]
	public unsafe static long Invoke([MangledName("__number")][NativeType("long")] long Number, [MangledName("__arg1")][NativeType("long")] long Arg1, [MangledName("__arg2")][NativeType("long")] long Arg2, [MangledName("__arg3")][NativeType("long")] long Arg3, [MangledName("__arg4")][NativeType("long")] long Arg4, [MangledName("__arg5")][NativeType("long")] long Arg5, [MangledName("__arg6")][NativeType("long")] long Arg6)
	{
		long num = 0L;
		long a = 0L;
		long a2 = 0L;
		long a3 = 0L;
		Llvm_lifetime_start_p0.Invoke(8L, &num);
		num = -6148914691236517206L;
		Llvm_lifetime_start_p0.Invoke(8L, &a);
		a = Arg4;
		Llvm_lifetime_start_p0.Invoke(8L, &a2);
		a2 = Arg5;
		Llvm_lifetime_start_p0.Invoke(8L, &a3);
		a3 = Arg6;
		num = IntrinsicFunctions.DotnetSyscall(Number, Arg1, Arg2, Arg3, a, a2, a3);
		long result = num;
		Llvm_lifetime_end_p0.Invoke(8L, &a3);
		Llvm_lifetime_end_p0.Invoke(8L, &a2);
		Llvm_lifetime_end_p0.Invoke(8L, &a);
		Llvm_lifetime_end_p0.Invoke(8L, &num);
		return result;
	}
}
