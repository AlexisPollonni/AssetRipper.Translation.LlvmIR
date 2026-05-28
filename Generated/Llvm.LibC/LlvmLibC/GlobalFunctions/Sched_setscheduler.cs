using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Sched_setscheduler
{
	[MangledName("sched_setscheduler")]
	[DemangledName("sched_setscheduler")]
	public unsafe static int Invoke([MangledName("tid")] int Tid, [MangledName("policy")] int Policy, [MangledName("param")] void* Param)
	{
		int num = 0;
		Llvm_lifetime_start_p0.Invoke(4L, &num);
		num = Syscall_impl_int_int_int_sched_param_const.Invoke(144L, Tid, Policy, Param);
		int result;
		if (num < 0)
		{
			Errno_Assignment.Invoke(A: -num, This: Libc_errno.Pointer);
			result = -1;
		}
		else
		{
			result = num;
		}
		Llvm_lifetime_end_p0.Invoke(4L, &num);
		return result;
	}
}
