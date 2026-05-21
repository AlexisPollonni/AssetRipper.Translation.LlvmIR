using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Remove
{
	[MangledName("remove")]
	[DemangledName("remove")]
	public unsafe static int Invoke([MangledName("path")] void* Path)
	{
		int num = 0;
		Llvm_lifetime_start_p0.Invoke(4L, &num);
		num = Llvm_libc_20_1_2_syscall_impl_int_int_char_const_int.Invoke(263L, -100, Path, 0);
		if (num == -21)
		{
			num = Llvm_libc_20_1_2_syscall_impl_int_int_char_const_int.Invoke(263L, -100, Path, 512);
		}
		int result;
		if (num >= 0)
		{
			result = 0;
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
