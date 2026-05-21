using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class isatty
{
	public unsafe static int Invoke(int fd)
	{
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		llvm_lifetime_start_p0.Invoke(4L, &num);
		num = 305441741;
		llvm_lifetime_start_p0.Invoke(4L, &num2);
		num2 = 305441741;
		llvm_lifetime_start_p0.Invoke(4L, &num3);
		num3 = syscall_impl_int_int_int_int.Invoke(16L, fd, 21540, &num2);
		int result;
		if (num3 == 0)
		{
			result = 1;
		}
		else
		{
			Errno_Assignment.Invoke(a: -num3, @this: libc_errno.Pointer);
			result = 0;
		}
		llvm_lifetime_end_p0.Invoke(4L, &num3);
		llvm_lifetime_end_p0.Invoke(4L, &num2);
		llvm_lifetime_end_p0.Invoke(4L, &num);
		return result;
	}
}
