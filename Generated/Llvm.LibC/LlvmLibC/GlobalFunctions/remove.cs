using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class remove
{
	public unsafe static int Invoke(void* path)
	{
		int num = 0;
		llvm_lifetime_start_p0.Invoke(4L, &num);
		num = int_syscall_impl_int_int_char_const_int_long_int_char_const_int.Invoke(263L, -100, path, 0);
		if (num == -21)
		{
			num = int_syscall_impl_int_int_char_const_int_long_int_char_const_int.Invoke(263L, -100, path, 512);
		}
		int result;
		if (num >= 0)
		{
			result = 0;
		}
		else
		{
			Errno_operator_int_dntwiy.Invoke(a: -num, @this: libc_errno.Pointer);
			result = -1;
		}
		llvm_lifetime_end_p0.Invoke(4L, &num);
		return result;
	}
}
