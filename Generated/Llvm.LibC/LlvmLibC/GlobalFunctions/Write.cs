using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Write
{
	[MangledName("write")]
	[DemangledName("write")]
	public unsafe static long Invoke([MangledName("fd")] int Fd, [MangledName("buf")] void* Buf, [MangledName("count")] long Count)
	{
		long num = 0L;
		Llvm_lifetime_start_p0.Invoke(8L, &num);
		num = Syscall_impl_long_int_void_const_unsigned_long.Invoke(1L, Fd, Buf, Count);
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
