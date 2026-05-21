using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Posix_madvise
{
	[MangledName("posix_madvise")]
	[DemangledName("posix_madvise")]
	public unsafe static int Invoke([MangledName("addr")] void* Addr, [MangledName("size")] long Size, [MangledName("advice")] int Advice)
	{
		int num = 0;
		int result;
		if (Advice == 4)
		{
			result = 0;
		}
		else
		{
			Llvm_lifetime_start_p0.Invoke(4L, &num);
			num = Llvm_libc_20_1_2_syscall_impl_int_long_unsigned_long_int.Invoke(28L, unchecked((long)Addr), Size, Advice);
			result = ((num < 0) ? (-num) : 0);
			Llvm_lifetime_end_p0.Invoke(4L, &num);
		}
		return result;
	}
}
