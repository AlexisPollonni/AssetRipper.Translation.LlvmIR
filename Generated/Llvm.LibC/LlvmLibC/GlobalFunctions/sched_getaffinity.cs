using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class sched_getaffinity
{
	public unsafe static int Invoke(int tid, long cpuset_size, void* mask)
	{
		int num = 0;
		void* ptr = null;
		long num2 = 0L;
		llvm_lifetime_start_p0.Invoke(4L, &num);
		num = int_syscall_impl_int_int_unsigned_long_cpu_set_t_long_int_unsigned_long_cpu_set_t.Invoke(204L, tid, cpuset_size, mask);
		int result;
		if (num < 0)
		{
			Errno_operator_int_dntwiy.Invoke(a: -num, @this: libc_errno.Pointer);
			result = -1;
		}
		else
		{
			unchecked
			{
				if ((ulong)num < (ulong)cpuset_size)
				{
					llvm_lifetime_start_p0.Invoke(8L, &ptr);
					ptr = mask;
					llvm_lifetime_start_p0.Invoke(8L, &num2);
					for (num2 = num; (ulong)num2 < (ulong)cpuset_size; num2++)
					{
						((sbyte*)ptr)[num2] = 0;
					}
					llvm_lifetime_end_p0.Invoke(8L, &num2);
					llvm_lifetime_end_p0.Invoke(8L, &ptr);
				}
				result = 0;
			}
		}
		llvm_lifetime_end_p0.Invoke(4L, &num);
		return result;
	}
}
