using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Close
{
	public unsafe static readonly void* __pointer = (delegate*<int, int>)(&Invoke);

	[MangledName("close")]
	[DemangledName("close")]
	public unsafe static int Invoke([MangledName("fd")] int Fd)
	{
		int num = 0;
		Llvm_lifetime_start_p0.Invoke(4L, &num);
		num = Syscall_impl_int_int.Invoke(3L, Fd);
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
