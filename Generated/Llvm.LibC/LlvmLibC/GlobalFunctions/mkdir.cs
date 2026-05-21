using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class mkdir
{
	public unsafe static int Invoke(void* path, int mode)
	{
		int num = 0;
		llvm_lifetime_start_p0.Invoke(4L, &num);
		num = syscall_impl_int_char_const_unsigned_int.Invoke(83L, path, mode);
		int result;
		if (num < 0)
		{
			Errno_Assignment.Invoke(a: -num, @this: libc_errno.Pointer);
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
