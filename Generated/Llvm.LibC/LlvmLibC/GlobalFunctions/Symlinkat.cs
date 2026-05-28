using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Symlinkat
{
	[MangledName("symlinkat")]
	[DemangledName("symlinkat")]
	public unsafe static int Invoke([MangledName("path1")] void* Path1, [MangledName("fd")] int Fd, [MangledName("path2")] void* Path2)
	{
		int num = 0;
		Llvm_lifetime_start_p0.Invoke(4L, &num);
		num = Syscall_impl_int_char_const_int_char_const.Invoke(266L, Path1, Fd, Path2);
		int result;
		if (num < 0)
		{
			Errno_Assignment.Invoke(A: -num, This: Libc_errno.Pointer);
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
