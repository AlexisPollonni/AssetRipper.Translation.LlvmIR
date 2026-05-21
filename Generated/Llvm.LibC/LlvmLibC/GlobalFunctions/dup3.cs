using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class dup3
{
	public unsafe static int Invoke(int oldfd, int newfd, int flags)
	{
		int num = 0;
		llvm_lifetime_start_p0.Invoke(4L, &num);
		num = syscall_impl_int_int_int_int.Invoke(292L, oldfd, newfd, flags);
		int result;
		if (num >= 0)
		{
			result = num;
		}
		else
		{
			Errno_Assignment.Invoke(a: -num, @this: libc_errno.Pointer);
			result = -1;
		}
		llvm_lifetime_end_p0.Invoke(4L, &num);
		return result;
	}
}
