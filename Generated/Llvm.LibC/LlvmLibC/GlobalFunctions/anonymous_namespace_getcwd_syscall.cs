using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class anonymous_namespace_getcwd_syscall
{
	[MangledName("_ZN19__llvm_libc_20_1_2_12_GLOBAL__N_114getcwd_syscallEPcm")]
	[DemangledName("__llvm_libc_20_1_2_::(anonymous namespace)::getcwd_syscall(char*, unsigned long)")]
	public unsafe static bool Invoke([NativeType("char*")] void* buf, [NativeType("unsigned long")] long size)
	{
		int num = 0;
		llvm_lifetime_start_p0.Invoke(4L, &num);
		num = syscall_impl_int_char_unsigned_long.Invoke(79L, buf, size);
		bool result;
		if (num < 0)
		{
			Errno_Assignment.Invoke(a: -num, @this: libc_errno.Pointer);
			result = false;
		}
		else if (num == 0 || *unchecked((sbyte*)buf) != 47)
		{
			Errno_Assignment.Invoke(libc_errno.Pointer, 2);
			result = false;
		}
		else
		{
			result = true;
		}
		llvm_lifetime_end_p0.Invoke(4L, &num);
		return result;
	}
}
