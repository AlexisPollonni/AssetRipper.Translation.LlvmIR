using System.Runtime.CompilerServices;
using LlvmLibC.GlobalVariables;
using LlvmLibC.InlineArrays;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class tcgetattr
{
	public unsafe static int Invoke(int fd, termios* t)
	{
		kernel_termios kernel_termios2 = default(kernel_termios);
		int num = 0;
		long num2 = 0L;
		long num3 = 0L;
		long num4 = 0L;
		llvm_lifetime_start_p0.Invoke(36L, &kernel_termios2);
		llvm_memset_p0_i64.Invoke(&kernel_termios2, -86, 36L, isVolatile: false);
		llvm_lifetime_start_p0.Invoke(4L, &num);
		num = syscall_impl_int_int_int_kernel_termios.Invoke(16L, fd, 21505, &kernel_termios2);
		int result;
		if (num < 0)
		{
			Errno_Assignment.Invoke(a: -num, @this: libc_errno.Pointer);
			result = -1;
		}
		else
		{
			t->c_iflag = kernel_termios2.c_iflag;
			t->c_oflag = kernel_termios2.c_oflag;
			t->c_cflag = kernel_termios2.c_cflag;
			t->c_lflag = kernel_termios2.c_lflag;
			t->c_ispeed = kernel_termios2.c_cflag & 0x100F;
			t->c_ospeed = kernel_termios2.c_cflag & 0x100F;
			llvm_lifetime_start_p0.Invoke(8L, &num2);
			num2 = 19L;
			llvm_lifetime_start_p0.Invoke(8L, &num3);
			unchecked
			{
				for (num3 = 0L; (ulong)num3 < (ulong)num2; num3++)
				{
					sbyte b = Unsafe.As<InlineArray19_SByte, sbyte>(ref Unsafe.AddByteOffset(ref kernel_termios2.c_cc, (nint)num3));
					((sbyte*)(&t->c_cc))[num3] = b;
				}
				llvm_lifetime_end_p0.Invoke(8L, &num3);
				if (32uL > (ulong)num2)
				{
					llvm_lifetime_start_p0.Invoke(8L, &num4);
					for (num4 = num2; (ulong)num4 < 32uL; num4++)
					{
						((sbyte*)(&t->c_cc))[num4] = 0;
					}
					llvm_lifetime_end_p0.Invoke(8L, &num4);
				}
				result = 0;
				llvm_lifetime_end_p0.Invoke(8L, &num2);
			}
		}
		llvm_lifetime_end_p0.Invoke(4L, &num);
		llvm_lifetime_end_p0.Invoke(36L, &kernel_termios2);
		return result;
	}
}
