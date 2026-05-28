using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Tcgetsid
{
	[MangledName("tcgetsid")]
	[DemangledName("tcgetsid")]
	public unsafe static int Invoke([MangledName("fd")] int Fd)
	{
		int num = 0;
		int num2 = 0;
		Llvm_lifetime_start_p0.Invoke(4L, &num);
		num = -1431655766;
		Llvm_lifetime_start_p0.Invoke(4L, &num2);
		num2 = Syscall_impl_int_int_int_int.Invoke(16L, Fd, 21545, &num);
		int result;
		if (num2 < 0)
		{
			Errno_Assignment.Invoke(A: -num2, This: Libc_errno.Pointer);
			result = -1;
		}
		else
		{
			result = num;
		}
		Llvm_lifetime_end_p0.Invoke(4L, &num2);
		Llvm_lifetime_end_p0.Invoke(4L, &num);
		return result;
	}
}
