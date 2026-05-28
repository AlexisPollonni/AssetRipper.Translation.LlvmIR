using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Fstat
{
	[MangledName("fstat")]
	[DemangledName("fstat")]
	public unsafe static int Invoke([MangledName("fd")] int Fd, [MangledName("statbuf")] global::LlvmLibC.Structures.Stat* Statbuf)
	{
		int num = 0;
		Llvm_lifetime_start_p0.Invoke(4L, &num);
		num = Llvm_libc_20_1_2_statx.Invoke(Fd, Str_110.Pointer, 4096, Statbuf);
		int result;
		if (num != 0)
		{
			Errno_Assignment.Invoke(A: num, This: Llvm_libc_20_1_2_libc_errno.Pointer);
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
