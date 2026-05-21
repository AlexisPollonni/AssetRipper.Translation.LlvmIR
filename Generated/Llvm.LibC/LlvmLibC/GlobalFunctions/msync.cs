using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class msync
{
	public unsafe static int Invoke(void* addr, long len, int flags)
	{
		long num = 0L;
		void* ptr = addr;
		llvm_lifetime_start_p0.Invoke(8L, &num);
		num = syscall_impl.Invoke(26L, cpp_bit_cast_long_void.Invoke(&ptr), len, flags);
		unchecked
		{
			int result;
			if (num < 0L)
			{
				Errno_Assignment.Invoke(a: (int)checked(-num), @this: libc_errno.Pointer);
				result = -1;
			}
			else
			{
				result = 0;
			}
			llvm_lifetime_end_p0.Invoke(8L, &num);
			return result;
		}
	}
}
