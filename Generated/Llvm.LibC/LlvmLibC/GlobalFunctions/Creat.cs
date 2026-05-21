using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Creat
{
	[MangledName("creat")]
	[DemangledName("creat")]
	public unsafe static int Invoke([MangledName("path")] void* Path, [MangledName("mode_flags")] int Mode_flags)
	{
		int num = 0;
		Llvm_lifetime_start_p0.Invoke(4L, &num);
		num = Llvm_libc_20_1_2_syscall_impl_int_char_const_int_int.Invoke(2L, Path, 577, Mode_flags);
		int result;
		if (num > 0)
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
