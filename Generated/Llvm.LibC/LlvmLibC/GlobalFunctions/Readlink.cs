using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Readlink
{
	[MangledName("readlink")]
	[DemangledName("readlink")]
	public unsafe static long Invoke([MangledName("path")] void* Path, [MangledName("buf")] void* Buf, [MangledName("bufsize")] long Bufsize)
	{
		long num = 0L;
		Llvm_lifetime_start_p0.Invoke(8L, &num);
		num = Llvm_libc_20_1_2_syscall_impl_long_char_const_char_unsigned_long.Invoke(89L, Path, Buf, Bufsize);
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
