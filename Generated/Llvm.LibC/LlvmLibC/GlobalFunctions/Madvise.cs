using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Madvise
{
	[MangledName("madvise")]
	[DemangledName("madvise")]
	public unsafe static int Invoke([MangledName("addr")] void* Addr, [MangledName("size")] long Size, [MangledName("advice")] int Advice)
	{
		int num = 0;
		Llvm_lifetime_start_p0.Invoke(4L, &num);
		num = Syscall_impl_int_long_unsigned_long_int.Invoke(28L, unchecked((long)Addr), Size, Advice);
		int result;
		if (num < 0)
		{
			Errno_Assignment.Invoke(A: -num, This: Libc_errno.Pointer);
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
