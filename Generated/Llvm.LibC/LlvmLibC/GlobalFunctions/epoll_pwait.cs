using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class epoll_pwait
{
	public unsafe static int Invoke(int epfd, void* events, int maxevents, int timeout, void* sigmask)
	{
		int num = 0;
		llvm_lifetime_start_p0.Invoke(4L, &num);
		num = unchecked(int_syscall_impl_int_int_long_int_int_long_int_long_int_long_int_int_long_int.Invoke(281L, epfd, (long)events, maxevents, timeout, (long)sigmask, 8));
		int result;
		if (num < 0)
		{
			Errno_operator_int_dntwiy.Invoke(a: -num, @this: libc_errno.Pointer);
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
