using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Anonymous_namespace_getcwd_syscall
{
	[MangledName("_ZN19__llvm_libc_20_1_2_12_GLOBAL__N_114getcwd_syscallEPcm")]
	[DemangledName("__llvm_libc_20_1_2_::(anonymous namespace)::getcwd_syscall(char*, unsigned long)")]
	public unsafe static bool Invoke([MangledName("buf")][NativeType("char*")] void* Buf, [MangledName("size")][NativeType("unsigned long")] long Size)
	{
		int num = 0;
		Llvm_lifetime_start_p0.Invoke(4L, &num);
		num = Llvm_libc_20_1_2_syscall_impl_int_char_unsigned_long.Invoke(79L, Buf, Size);
		bool result;
		if (num < 0)
		{
			Errno_Assignment.Invoke(A: -num, This: Llvm_libc_20_1_2_libc_errno.Pointer);
			result = false;
		}
		else if (num == 0 || *unchecked((sbyte*)Buf) != 47)
		{
			Errno_Assignment.Invoke(Llvm_libc_20_1_2_libc_errno.Pointer, 2);
			result = false;
		}
		else
		{
			result = true;
		}
		Llvm_lifetime_end_p0.Invoke(4L, &num);
		return result;
	}
}
