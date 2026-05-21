using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class dup
{
	public unsafe static int Invoke(int fd)
	{
		int num = 0;
		llvm_lifetime_start_p0.Invoke(4L, &num);
		num = syscall_impl_int_int.Invoke(32L, fd);
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
