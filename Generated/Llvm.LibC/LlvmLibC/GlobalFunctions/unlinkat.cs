using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class unlinkat
{
	public unsafe static int Invoke(int dfd, void* path, int flags)
	{
		int num = 0;
		llvm_lifetime_start_p0.Invoke(4L, &num);
		num = syscall_impl_int_int_char_const_int.Invoke(263L, dfd, path, flags);
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
