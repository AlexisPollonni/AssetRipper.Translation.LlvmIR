using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class pwrite
{
	public unsafe static long Invoke(int fd, void* buf, long count, long offset)
	{
		long num = 0L;
		llvm_lifetime_start_p0.Invoke(8L, &num);
		num = -6148914691236517206L;
		num = long_syscall_impl_long_int_void_const_unsigned_long_long_long_int_void_const_unsigned_long_long.Invoke(18L, fd, buf, count, offset);
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
