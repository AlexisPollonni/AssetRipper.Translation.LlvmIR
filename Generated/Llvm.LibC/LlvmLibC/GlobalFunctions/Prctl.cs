using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Prctl
{
	public unsafe static readonly void* __pointer = (delegate*<int, long, long, long, long, int>)(&Invoke);

	[MangledName("prctl")]
	[DemangledName("prctl")]
	public unsafe static int Invoke([MangledName("option")] int Option, [MangledName("arg2")] long Arg2, [MangledName("arg3")] long Arg3, [MangledName("arg4")] long Arg4, [MangledName("arg5")] long Arg5)
	{
		long num = 0L;
		Llvm_lifetime_start_p0.Invoke(8L, &num);
		num = Syscall_impl.Invoke(157L, Option, Arg2, Arg3, Arg4, Arg5);
		unchecked
		{
			int result;
			if (num < 0L)
			{
				Errno_Assignment.Invoke(A: (int)checked(-num), This: Libc_errno.Pointer);
				result = -1;
			}
			else
			{
				result = (int)num;
			}
			Llvm_lifetime_end_p0.Invoke(8L, &num);
			return result;
		}
	}
}
