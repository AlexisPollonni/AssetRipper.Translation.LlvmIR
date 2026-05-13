using AssetRipper.Translation.LlvmIR.Runtime;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class read
{
	public unsafe static readonly void* __pointer = PointerIndices.Register((delegate*<int, void*, long, long>)(&Invoke));

	public unsafe static long Invoke(int fd, void* buf, long count)
	{
		long num = 0L;
		llvm_lifetime_start_p0.Invoke(8L, &num);
		num = long_syscall_impl_long_int_void_unsigned_long_long_int_void_unsigned_long.Invoke(0L, fd, buf, count);
		unchecked
		{
			long result;
			if (num < 0L)
			{
				Errno_operator_int_dntwiy.Invoke(a: (int)checked(-num), @this: libc_errno.Pointer);
				result = -1L;
			}
			else
			{
				result = num;
			}
			llvm_lifetime_end_p0.Invoke(8L, &num);
			return result;
		}
	}
}
