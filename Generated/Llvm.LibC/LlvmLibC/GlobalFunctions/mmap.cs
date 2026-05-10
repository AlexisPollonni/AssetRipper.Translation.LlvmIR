using LlvmLibC.GlobalVariables;
using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class mmap
{
	public unsafe static readonly void* __pointer = PointerIndices.Register((delegate*<void*, long, int, int, int, long, void*>)(&Invoke));

	public unsafe static void* Invoke(void* addr, long size, int prot, int flags, int fd, long offset)
	{
		long number = 0L;
		long arg = 0L;
		long num = 0L;
		llvm_lifetime_start_p0.Invoke(8L, &number);
		number = 9L;
		llvm_lifetime_start_p0.Invoke(8L, &arg);
		arg = offset;
		llvm_lifetime_start_p0.Invoke(8L, &num);
		unchecked
		{
			num = syscall_impl_long_long_long_long_long_long_long.Invoke(number, (long)addr, size, prot, flags, fd, arg);
			void* result;
			if (num < 0L && num > -4096L)
			{
				Errno_operator_int_dntwiy.Invoke(a: (int)checked(-num), @this: libc_errno.Pointer);
				result = (void*)ulong.MaxValue;
			}
			else
			{
				result = (void*)num;
			}
			llvm_lifetime_end_p0.Invoke(8L, &num);
			llvm_lifetime_end_p0.Invoke(8L, &arg);
			llvm_lifetime_end_p0.Invoke(8L, &number);
			return result;
		}
	}
}
