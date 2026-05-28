using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Stat
{
	[MangledName("stat")]
	[DemangledName("stat")]
	public unsafe static int Invoke([MangledName("path")] void* Path, [MangledName("statbuf")] global::LlvmLibC.Structures.Stat* Statbuf)
	{
		int num = 0;
		Llvm_lifetime_start_p0.Invoke(4L, &num);
		num = Llvm_libc_20_1_2_statx.Invoke(-100, Path, 0, Statbuf);
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
