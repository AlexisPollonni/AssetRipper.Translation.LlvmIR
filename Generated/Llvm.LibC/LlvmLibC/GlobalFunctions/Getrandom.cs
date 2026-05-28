using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Getrandom
{
	[MangledName("getrandom")]
	[DemangledName("getrandom")]
	public unsafe static long Invoke([MangledName("buf")] void* Buf, [MangledName("buflen")] long Buflen, [MangledName("flags")] int Flags)
	{
		long num = 0L;
		Llvm_lifetime_start_p0.Invoke(8L, &num);
		num = Syscall_impl_long_void_unsigned_long_unsigned_int.Invoke(318L, Buf, Buflen, Flags);
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
