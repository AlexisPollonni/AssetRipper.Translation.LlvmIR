using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Rename
{
	[MangledName("rename")]
	[DemangledName("rename")]
	public unsafe static int Invoke([MangledName("oldpath")] void* Oldpath, [MangledName("newpath")] void* Newpath)
	{
		int num = 0;
		Llvm_lifetime_start_p0.Invoke(4L, &num);
		num = Syscall_impl_int_int_char_const_int_char_const_int.Invoke(316L, -100, Oldpath, -100, Newpath, 0);
		int result;
		if (num >= 0)
		{
			result = 0;
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
