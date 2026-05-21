using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class mincore
{
	public unsafe static int Invoke(void* addr, long len, void* vec)
	{
		long num = 0L;
		llvm_lifetime_start_p0.Invoke(8L, &num);
		unchecked
		{
			num = syscall_impl.Invoke(27L, (long)addr, len, (long)vec);
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
