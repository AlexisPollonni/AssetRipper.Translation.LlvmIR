using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class readlink
{
	public unsafe static long Invoke(void* path, void* buf, long bufsize)
	{
		long num = 0L;
		llvm_lifetime_start_p0.Invoke(8L, &num);
		num = syscall_impl_long_char_const_char_unsigned_long.Invoke(89L, path, buf, bufsize);
		unchecked
		{
			long result;
			if (num < 0L)
			{
				Errno_Assignment.Invoke(a: (int)checked(-num), @this: libc_errno.Pointer);
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
