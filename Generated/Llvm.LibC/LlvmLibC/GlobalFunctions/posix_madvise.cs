using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class posix_madvise
{
	public unsafe static int Invoke(void* addr, long size, int advice)
	{
		int num = 0;
		int result;
		if (advice == 4)
		{
			result = 0;
		}
		else
		{
			llvm_lifetime_start_p0.Invoke(4L, &num);
			num = int_syscall_impl_int_long_unsigned_long_int_long_long_unsigned_long_int.Invoke(28L, unchecked((long)addr), size, advice);
			result = ((num < 0) ? (-num) : 0);
			llvm_lifetime_end_p0.Invoke(4L, &num);
		}
		return result;
	}
}
