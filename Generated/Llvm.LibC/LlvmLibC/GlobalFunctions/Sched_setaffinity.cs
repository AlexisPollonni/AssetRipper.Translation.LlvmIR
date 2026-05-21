using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Sched_setaffinity
{
	[MangledName("sched_setaffinity")]
	[DemangledName("sched_setaffinity")]
	public unsafe static int Invoke([MangledName("tid")] int Tid, [MangledName("cpuset_size")] long Cpuset_size, [MangledName("mask")] void* Mask)
	{
		int num = 0;
		Llvm_lifetime_start_p0.Invoke(4L, &num);
		num = Llvm_libc_20_1_2_syscall_impl_int_int_unsigned_long_cpu_set_t_const.Invoke(203L, Tid, Cpuset_size, Mask);
		int result;
		if (num < 0)
		{
			Errno_Assignment.Invoke(A: -num, This: Llvm_libc_20_1_2_libc_errno.Pointer);
			result = -1;
		}
		else
		{
			result = 0;
		}
		Llvm_lifetime_end_p0.Invoke(4L, &num);
		return result;
	}
}
