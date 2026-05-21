using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class fstat
{
	public unsafe static int Invoke(int fd, LlvmLibC.Structures.stat* statbuf)
	{
		int num = 0;
		llvm_lifetime_start_p0.Invoke(4L, &num);
		num = statx.Invoke(fd, str_110.Pointer, 4096, statbuf);
		int result;
		if (num != 0)
		{
			Errno_Assignment.Invoke(a: num, @this: libc_errno.Pointer);
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
