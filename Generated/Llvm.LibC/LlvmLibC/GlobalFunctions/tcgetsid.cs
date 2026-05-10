using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class tcgetsid
{
	public unsafe static int Invoke(int fd)
	{
		int num = 0;
		int num2 = 0;
		llvm_lifetime_start_p0.Invoke(4L, &num);
		num = -1431655766;
		llvm_lifetime_start_p0.Invoke(4L, &num2);
		num2 = int_syscall_impl_int_int_int_int_long_int_int_int_zzjp7j.Invoke(16L, fd, 21545, &num);
		int result;
		if (num2 < 0)
		{
			Errno_operator_int_dntwiy.Invoke(a: -num2, @this: libc_errno.Pointer);
			result = -1;
		}
		else
		{
			result = num;
		}
		llvm_lifetime_end_p0.Invoke(4L, &num2);
		llvm_lifetime_end_p0.Invoke(4L, &num);
		return result;
	}
}
