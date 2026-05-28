using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Uname
{
	[MangledName("uname")]
	[DemangledName("uname")]
	public unsafe static int Invoke([MangledName("name")] void* Name)
	{
		int num = 0;
		Llvm_lifetime_start_p0.Invoke(4L, &num);
		num = Syscall_impl_int_utsname.Invoke(63L, Name);
		int result;
		if (num >= 0)
		{
			result = 1;
		}
		else
		{
			Errno_Assignment.Invoke(A: -num, This: Libc_errno.Pointer);
			result = -1;
		}
		Llvm_lifetime_end_p0.Invoke(4L, &num);
		return result;
	}
}
