using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class creat
{
	public unsafe static int Invoke(void* path, int mode_flags)
	{
		int num = 0;
		llvm_lifetime_start_p0.Invoke(4L, &num);
		num = syscall_impl_int_char_const_int_int.Invoke(2L, path, 577, mode_flags);
		int result;
		if (num > 0)
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
