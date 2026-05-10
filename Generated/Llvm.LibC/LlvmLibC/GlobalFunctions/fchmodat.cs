using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class fchmodat
{
	public unsafe static int Invoke(int dirfd, void* path, int mode, int flags)
	{
		int num = 0;
		llvm_lifetime_start_p0.Invoke(4L, &num);
		num = int_syscall_impl_int_int_char_const_unsigned_int_int_long_int_char_const_unsigned_int_int.Invoke(268L, dirfd, path, mode, flags);
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
