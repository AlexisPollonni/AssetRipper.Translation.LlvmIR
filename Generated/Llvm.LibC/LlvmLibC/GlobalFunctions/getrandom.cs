using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class getrandom
{
	public unsafe static long Invoke(void* buf, long buflen, int flags)
	{
		long num = 0L;
		llvm_lifetime_start_p0.Invoke(8L, &num);
		num = long_syscall_impl_long_void_unsigned_long_unsigned_int_long_void_unsigned_long_unsigned_int.Invoke(318L, buf, buflen, flags);
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
