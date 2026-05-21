using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class remap_file_pages
{
	public unsafe static int Invoke(void* addr, long size, int prot, long pgoff, int flags)
	{
		int num = 0;
		llvm_lifetime_start_p0.Invoke(4L, &num);
		num = syscall_impl_int_long_unsigned_long_int_unsigned_long_int.Invoke(216L, unchecked((long)addr), size, prot, pgoff, flags);
		int result;
		if (num < 0)
		{
			Errno_Assignment.Invoke(a: -num, @this: libc_errno.Pointer);
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
