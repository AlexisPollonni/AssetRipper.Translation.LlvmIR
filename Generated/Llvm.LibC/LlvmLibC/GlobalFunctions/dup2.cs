using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class dup2
{
	public unsafe static int Invoke(int oldfd, int newfd)
	{
		int num = 0;
		llvm_lifetime_start_p0.Invoke(4L, &num);
		num = syscall_impl_int_int_int.Invoke(33L, oldfd, newfd);
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
