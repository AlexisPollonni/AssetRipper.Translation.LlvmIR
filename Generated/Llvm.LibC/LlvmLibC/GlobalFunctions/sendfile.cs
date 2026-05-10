using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class sendfile
{
	public unsafe static long Invoke(int out_fd, int in_fd, void* offset, long count)
	{
		long num = 0L;
		llvm_lifetime_start_p0.Invoke(8L, &num);
		num = long_syscall_impl_long_int_int_long_unsigned_long_long_int_int_long_unsigned_long.Invoke(40L, in_fd, out_fd, offset, count);
		unchecked
		{
			long result;
			if (num < 0L)
			{
				Errno_operator_int_dntwiy.Invoke(a: (int)checked(-num), @this: libc_errno.Pointer);
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
