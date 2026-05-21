using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Mlock2
{
	[MangledName("mlock2")]
	[DemangledName("mlock2")]
	public unsafe static int Invoke([MangledName("addr")] void* Addr, [MangledName("len")] long Len, [MangledName("flags")] int Flags)
	{
		long num = 0L;
		void* ptr = Addr;
		Llvm_lifetime_start_p0.Invoke(8L, &num);
		num = Llvm_libc_20_1_2_syscall_impl.Invoke(325L, Cpp_bit_cast_long_void_const.Invoke(&ptr), Len, Flags);
		unchecked
		{
			int result;
			if (num < 0L)
			{
				Errno_Assignment.Invoke(A: (int)checked(-num), This: Llvm_libc_20_1_2_libc_errno.Pointer);
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
