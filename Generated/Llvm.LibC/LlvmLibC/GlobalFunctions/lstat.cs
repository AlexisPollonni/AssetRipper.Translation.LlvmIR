using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class lstat
{
	public unsafe static int Invoke(void* path, void* statbuf)
	{
		int num = 0;
		llvm_lifetime_start_p0.Invoke(4L, &num);
		num = statx_int_char_const_int_stat.Invoke(-100, path, 256, statbuf);
		int result;
		if (num != 0)
		{
			Errno_operator_int_dntwiy.Invoke(a: num, @this: libc_errno.Pointer);
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
