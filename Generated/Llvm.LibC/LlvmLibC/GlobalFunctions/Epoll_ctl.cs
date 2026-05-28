using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Epoll_ctl
{
	[MangledName("epoll_ctl")]
	[DemangledName("epoll_ctl")]
	public unsafe static int Invoke([MangledName("epfd")] int Epfd, [MangledName("op")] int Op, [MangledName("fd")] int Fd, [MangledName("event")] void* Event)
	{
		int num = 0;
		Llvm_lifetime_start_p0.Invoke(4L, &num);
		num = Syscall_impl_int_int_int_int_long.Invoke(233L, Epfd, Op, Fd, unchecked((long)Event));
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
