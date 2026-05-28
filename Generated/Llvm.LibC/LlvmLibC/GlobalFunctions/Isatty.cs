using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Isatty
{
	[MangledName("isatty")]
	[DemangledName("isatty")]
	public unsafe static int Invoke([MangledName("fd")] int Fd)
	{
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		Llvm_lifetime_start_p0.Invoke(4L, &num);
		num = 305441741;
		Llvm_lifetime_start_p0.Invoke(4L, &num2);
		num2 = 305441741;
		Llvm_lifetime_start_p0.Invoke(4L, &num3);
		num3 = Syscall_impl_int_int_int_int.Invoke(16L, Fd, 21540, &num2);
		int result;
		if (num3 == 0)
		{
			result = 1;
		}
		else
		{
			Errno_Assignment.Invoke(A: -num3, This: Libc_errno.Pointer);
			result = 0;
		}
		Llvm_lifetime_end_p0.Invoke(4L, &num3);
		Llvm_lifetime_end_p0.Invoke(4L, &num2);
		Llvm_lifetime_end_p0.Invoke(4L, &num);
		return result;
	}
}
