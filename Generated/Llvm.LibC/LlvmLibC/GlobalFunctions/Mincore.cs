using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Mincore
{
	[MangledName("mincore")]
	[DemangledName("mincore")]
	public unsafe static int Invoke([MangledName("addr")] void* Addr, [MangledName("len")] long Len, [MangledName("vec")] void* Vec)
	{
		long num = 0L;
		Llvm_lifetime_start_p0.Invoke(8L, &num);
		unchecked
		{
			num = Syscall_impl.Invoke(27L, (long)Addr, Len, (long)Vec);
			int result;
			if (num < 0L)
			{
				Errno_Assignment.Invoke(A: (int)checked(-num), This: Libc_errno.Pointer);
				result = -1;
			}
			else
			{
				result = 0;
			}
			Llvm_lifetime_end_p0.Invoke(8L, &num);
			return result;
		}
	}
}
