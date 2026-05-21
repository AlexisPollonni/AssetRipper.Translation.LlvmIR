using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class writev
{
	public unsafe static long Invoke(int fd, void* iov, int iovcnt)
	{
		long num = 0L;
		llvm_lifetime_start_p0.Invoke(8L, &num);
		num = syscall_impl_long_int_iovec_const_int.Invoke(20L, fd, iov, iovcnt);
		unchecked
		{
			long result;
			if (num < 0L)
			{
				Errno_Assignment.Invoke(a: (int)checked(-num), @this: libc_errno.Pointer);
				result = -1L;
			}
			else
			{
				result = num;
			}
			llvm_lifetime_end_p0.Invoke(8L, &num);
			return result;
		}
	}
}
