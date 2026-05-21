using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Linkat
{
	[MangledName("linkat")]
	[DemangledName("linkat")]
	public unsafe static int Invoke([MangledName("fd1")] int Fd1, [MangledName("path1")] void* Path1, [MangledName("fd2")] int Fd2, [MangledName("path2")] void* Path2, [MangledName("flags")] int Flags)
	{
		int num = 0;
		Llvm_lifetime_start_p0.Invoke(4L, &num);
		num = Llvm_libc_20_1_2_syscall_impl_int_int_char_const_int_char_const_int.Invoke(265L, Fd1, Path1, Fd2, Path2, Flags);
		int result;
		if (num < 0)
		{
			Errno_Assignment.Invoke(A: -num, This: Llvm_libc_20_1_2_libc_errno.Pointer);
			result = -1;
		}
		else
		{
			result = num;
		}
		Llvm_lifetime_end_p0.Invoke(4L, &num);
		return result;
	}
}
