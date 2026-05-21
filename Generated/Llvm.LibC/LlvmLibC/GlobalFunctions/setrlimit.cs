using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class setrlimit
{
	public unsafe static int Invoke(int res, void* limits)
	{
		int num = 0;
		llvm_lifetime_start_p0.Invoke(4L, &num);
		num = syscall_impl_int_int_int_rlimit_const_std_nullptr_t.Invoke(302L, 0, res, limits, null);
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
