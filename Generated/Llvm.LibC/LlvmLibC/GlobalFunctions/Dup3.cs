using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Dup3
{
	[MangledName("dup3")]
	[DemangledName("dup3")]
	public unsafe static int Invoke([MangledName("oldfd")] int Oldfd, [MangledName("newfd")] int Newfd, [MangledName("flags")] int Flags)
	{
		int num = 0;
		Llvm_lifetime_start_p0.Invoke(4L, &num);
		num = Llvm_libc_20_1_2_syscall_impl_int_int_int_int.Invoke(292L, Oldfd, Newfd, Flags);
		int result;
		if (num >= 0)
		{
			result = num;
		}
		else
		{
			Errno_Assignment.Invoke(A: -num, This: Llvm_libc_20_1_2_libc_errno.Pointer);
			result = -1;
		}
		Llvm_lifetime_end_p0.Invoke(4L, &num);
		return result;
	}
}
