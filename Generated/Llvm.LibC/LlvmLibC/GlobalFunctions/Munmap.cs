using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Munmap
{
	public unsafe static readonly void* __pointer = PointerIndices.Register((delegate*<void*, long, int>)(&Invoke));

	[MangledName("munmap")]
	[DemangledName("munmap")]
	public unsafe static int Invoke([MangledName("addr")] void* Addr, [MangledName("size")] long Size)
	{
		int num = 0;
		Llvm_lifetime_start_p0.Invoke(4L, &num);
		num = Llvm_libc_20_1_2_syscall_impl_int_long_unsigned_long.Invoke(11L, unchecked((long)Addr), Size);
		int result;
		if (num < 0)
		{
			Errno_Assignment.Invoke(A: -num, This: Llvm_libc_20_1_2_libc_errno.Pointer);
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
