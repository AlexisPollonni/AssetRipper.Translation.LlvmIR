using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Writev
{
	[MangledName("writev")]
	[DemangledName("writev")]
	public unsafe static long Invoke([MangledName("fd")] int Fd, [MangledName("iov")] void* Iov, [MangledName("iovcnt")] int Iovcnt)
	{
		long num = 0L;
		Llvm_lifetime_start_p0.Invoke(8L, &num);
		num = Llvm_libc_20_1_2_syscall_impl_long_int_iovec_const_int.Invoke(20L, Fd, Iov, Iovcnt);
		unchecked
		{
			long result;
			if (num < 0L)
			{
				Errno_Assignment.Invoke(A: (int)checked(-num), This: Llvm_libc_20_1_2_libc_errno.Pointer);
				result = -1L;
			}
			else
			{
				result = num;
			}
			Llvm_lifetime_end_p0.Invoke(8L, &num);
			return result;
		}
	}
}
