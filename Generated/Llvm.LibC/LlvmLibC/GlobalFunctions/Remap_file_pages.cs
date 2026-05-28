using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Remap_file_pages
{
	[MangledName("remap_file_pages")]
	[DemangledName("remap_file_pages")]
	public unsafe static int Invoke([MangledName("addr")] void* Addr, [MangledName("size")] long Size, [MangledName("prot")] int Prot, [MangledName("pgoff")] long Pgoff, [MangledName("flags")] int Flags)
	{
		int num = 0;
		Llvm_lifetime_start_p0.Invoke(4L, &num);
		num = Syscall_impl_int_long_unsigned_long_int_unsigned_long_int.Invoke(216L, unchecked((long)Addr), Size, Prot, Pgoff, Flags);
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
