using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Link
{
	[MangledName("link")]
	[DemangledName("link")]
	public unsafe static int Invoke([MangledName("path1")] void* Path1, [MangledName("path2")] void* Path2)
	{
		int num = 0;
		Llvm_lifetime_start_p0.Invoke(4L, &num);
		num = Llvm_libc_20_1_2_syscall_impl_int_char_const_char_const.Invoke(86L, Path1, Path2);
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
