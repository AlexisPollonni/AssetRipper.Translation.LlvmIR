using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class sysconf
{
	public unsafe static long Invoke(int name)
	{
		long num = 0L;
		llvm_lifetime_start_p0.Invoke(8L, &num);
		num = 0L;
		long result;
		if (name == 30)
		{
			result = unchecked((delegate*<long, long>)getauxval.__pointer)(6L);
		}
		else if (num < 0L)
		{
			Errno_operator_int_dntwiy.Invoke(libc_errno.Pointer, 22);
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
