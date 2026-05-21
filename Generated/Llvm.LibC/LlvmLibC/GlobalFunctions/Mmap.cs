using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Mmap
{
	public unsafe static readonly void* __pointer = PointerIndices.Register((delegate*<void*, long, int, int, int, long, void*>)(&Invoke));

	[MangledName("mmap")]
	[DemangledName("mmap")]
	public unsafe static void* Invoke([MangledName("addr")] void* Addr, [MangledName("size")] long Size, [MangledName("prot")] int Prot, [MangledName("flags")] int Flags, [MangledName("fd")] int Fd, [MangledName("offset")] long Offset)
	{
		long number = 0L;
		long arg = 0L;
		long num = 0L;
		Llvm_lifetime_start_p0.Invoke(8L, &number);
		number = 9L;
		Llvm_lifetime_start_p0.Invoke(8L, &arg);
		arg = Offset;
		Llvm_lifetime_start_p0.Invoke(8L, &num);
		unchecked
		{
			num = Llvm_libc_20_1_2_syscall_impl.Invoke(number, (long)Addr, Size, Prot, Flags, Fd, arg);
			void* result;
			if (num < 0L && num > -4096L)
			{
				Errno_Assignment.Invoke(A: (int)checked(-num), This: Llvm_libc_20_1_2_libc_errno.Pointer);
				result = (void*)ulong.MaxValue;
			}
			else
			{
				result = (void*)num;
			}
			Llvm_lifetime_end_p0.Invoke(8L, &num);
			Llvm_lifetime_end_p0.Invoke(8L, &arg);
			Llvm_lifetime_end_p0.Invoke(8L, &number);
			return result;
		}
	}
}
