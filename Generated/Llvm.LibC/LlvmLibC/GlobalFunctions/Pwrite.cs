using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Pwrite
{
	[MangledName("pwrite")]
	[DemangledName("pwrite")]
	public unsafe static long Invoke([MangledName("fd")] int Fd, [MangledName("buf")] void* Buf, [MangledName("count")] long Count, [MangledName("offset")] long Offset)
	{
		long num = 0L;
		Llvm_lifetime_start_p0.Invoke(8L, &num);
		num = -6148914691236517206L;
		num = Syscall_impl_long_int_void_const_unsigned_long_long.Invoke(18L, Fd, Buf, Count, Offset);
		unchecked
		{
			long result;
			if (num < 0L)
			{
				Errno_Assignment.Invoke(A: (int)checked(-num), This: Libc_errno.Pointer);
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
