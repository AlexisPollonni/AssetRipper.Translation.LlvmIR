using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class linkat
{
	public unsafe static int Invoke(int fd1, void* path1, int fd2, void* path2, int flags)
	{
		int num = 0;
		llvm_lifetime_start_p0.Invoke(4L, &num);
		num = syscall_impl_int_int_char_const_int_char_const_int.Invoke(265L, fd1, path1, fd2, path2, flags);
		int result;
		if (num < 0)
		{
			Errno_Assignment.Invoke(a: -num, @this: libc_errno.Pointer);
			result = -1;
		}
		else
		{
			result = num;
		}
		llvm_lifetime_end_p0.Invoke(4L, &num);
		return result;
	}
}
