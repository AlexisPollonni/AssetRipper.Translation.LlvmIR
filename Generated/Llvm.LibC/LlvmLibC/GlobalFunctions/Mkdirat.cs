using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Mkdirat
{
	[MangledName("mkdirat")]
	[DemangledName("mkdirat")]
	public unsafe static int Invoke([MangledName("dfd")] int Dfd, [MangledName("path")] void* Path, [MangledName("mode")] int Mode)
	{
		int num = 0;
		Llvm_lifetime_start_p0.Invoke(4L, &num);
		num = Syscall_impl_int_int_char_const_unsigned_int.Invoke(258L, Dfd, Path, Mode);
		int result;
		if (num < 0)
		{
			Errno_Assignment.Invoke(A: -num, This: Libc_errno.Pointer);
			result = -1;
		}
		else
		{
			result = 0;
		}
		Llvm_lifetime_end_p0.Invoke(4L, &num);
		return result;
	}
}
