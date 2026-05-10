using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class sched_getparam
{
	public unsafe static int Invoke(int tid, void* param)
	{
		int num = 0;
		llvm_lifetime_start_p0.Invoke(4L, &num);
		num = int_syscall_impl_int_int_sched_param_long_int_sched_param.Invoke(143L, tid, param);
		int result;
		if (num < 0)
		{
			Errno_operator_int_dntwiy.Invoke(a: -num, @this: libc_errno.Pointer);
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
