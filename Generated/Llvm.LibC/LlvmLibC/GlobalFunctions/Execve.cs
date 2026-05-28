using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Execve
{
	[MangledName("execve")]
	[DemangledName("execve")]
	public unsafe static int Invoke([MangledName("path")] void* Path, [MangledName("argv")] void* Argv, [MangledName("envp")] void* Envp)
	{
		int num = 0;
		Llvm_lifetime_start_p0.Invoke(4L, &num);
		num = Syscall_impl_int_char_const_char_const_char_const.Invoke(59L, Path, Argv, Envp);
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
