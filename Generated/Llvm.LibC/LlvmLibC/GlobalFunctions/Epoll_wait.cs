using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Epoll_wait
{
	[MangledName("epoll_wait")]
	[DemangledName("epoll_wait")]
	public unsafe static int Invoke([MangledName("epfd")] int Epfd, [MangledName("events")] void* Events, [MangledName("maxevents")] int Maxevents, [MangledName("timeout")] int Timeout)
	{
		int num = 0;
		Llvm_lifetime_start_p0.Invoke(4L, &num);
		num = Syscall_impl_int_int_long_int_int.Invoke(232L, Epfd, unchecked((long)Events), Maxevents, Timeout);
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
