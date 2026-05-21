using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class rename
{
	public unsafe static int Invoke(void* oldpath, void* newpath)
	{
		int num = 0;
		llvm_lifetime_start_p0.Invoke(4L, &num);
		num = syscall_impl_int_int_char_const_int_char_const_int.Invoke(316L, -100, oldpath, -100, newpath, 0);
		int result;
		if (num >= 0)
		{
			result = 0;
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
