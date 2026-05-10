using LlvmLibC.GlobalVariables;
using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class munmap
{
	public unsafe static readonly void* __pointer = PointerIndices.Register((delegate*<void*, long, int>)(&Invoke));

	public unsafe static int Invoke(void* addr, long size)
	{
		int num = 0;
		llvm_lifetime_start_p0.Invoke(4L, &num);
		num = int_syscall_impl_int_long_unsigned_long_long_long_unsigned_long.Invoke(11L, unchecked((long)addr), size);
		int result;
		if (num < 0)
		{
			Errno_operator_int_dntwiy.Invoke(a: -num, @this: libc_errno.Pointer);
			result = -1;
		}
		else
		{
			result = 0;
		}
		llvm_lifetime_end_p0.Invoke(4L, &num);
		return result;
	}
}
