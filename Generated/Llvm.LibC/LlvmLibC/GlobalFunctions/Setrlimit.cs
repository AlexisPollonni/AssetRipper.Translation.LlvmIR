using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Setrlimit
{
	[MangledName("setrlimit")]
	[DemangledName("setrlimit")]
	public unsafe static int Invoke([MangledName("res")] int Res, [MangledName("limits")] void* Limits)
	{
		int num = 0;
		Llvm_lifetime_start_p0.Invoke(4L, &num);
		num = Syscall_impl_int_int_int_rlimit_const_std_nullptr_t.Invoke(302L, 0, Res, Limits, null);
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
