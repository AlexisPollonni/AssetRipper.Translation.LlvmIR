using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class tcflush
{
	public unsafe static int Invoke(int fd, int queue_selector)
	{
		int num = 0;
		llvm_lifetime_start_p0.Invoke(4L, &num);
		num = int_syscall_impl_int_int_int_int_long_int_int_int_qknfsf.Invoke(16L, fd, 21515, queue_selector);
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
