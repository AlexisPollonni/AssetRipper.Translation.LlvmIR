using System.Runtime.CompilerServices;
using LlvmLibC.GlobalVariables;
using LlvmLibC.InlineArrays;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class tcsetattr
{
	public unsafe static int Invoke(int fd, int actions, termios* t)
	{
		kernel_termios kernel_termios2 = default(kernel_termios);
		long ts_76xnpk = 0L;
		long num = 0L;
		long num2 = 0L;
		long num3 = 0L;
		int num4 = 0;
		llvm_lifetime_start_p0.Invoke(36L, &kernel_termios2);
		llvm_memset_p0_i64.Invoke(&kernel_termios2, -86, 36L, isVolatile: false);
		llvm_lifetime_start_p0.Invoke(8L, &ts_76xnpk);
		ts_76xnpk = -6148914691236517206L;
		unchecked
		{
			int result;
			switch (actions)
			{
			case 0:
				ts_76xnpk = 21506L;
				goto IL_00a9;
			case 1:
				ts_76xnpk = 21507L;
				goto IL_00a9;
			case 2:
				ts_76xnpk = 21508L;
				goto IL_00a9;
			default:
				{
					Errno_Assignment.Invoke(libc_errno.Pointer, 22);
					result = -1;
					break;
				}
				IL_00a9:
				kernel_termios2.c_iflag = t->c_iflag;
				kernel_termios2.c_oflag = t->c_oflag;
				kernel_termios2.c_cflag = t->c_cflag;
				kernel_termios2.c_lflag = t->c_lflag;
				llvm_lifetime_start_p0.Invoke(8L, &num);
				num = 19L;
				llvm_lifetime_start_p0.Invoke(8L, &num2);
				for (num2 = 0L; (ulong)num2 < (ulong)num; num2++)
				{
					sbyte b = ((sbyte*)(&t->c_cc))[num2];
					Unsafe.As<InlineArray19_SByte, sbyte>(ref Unsafe.AddByteOffset(ref kernel_termios2.c_cc, (nint)num2)) = b;
				}
				llvm_lifetime_end_p0.Invoke(8L, &num2);
				if ((ulong)num < 19uL)
				{
					llvm_lifetime_start_p0.Invoke(8L, &num3);
					for (num3 = num; (ulong)num3 < 19uL; num3++)
					{
						Unsafe.As<InlineArray19_SByte, sbyte>(ref Unsafe.AddByteOffset(ref kernel_termios2.c_cc, (nint)num3)) = 0;
					}
					llvm_lifetime_end_p0.Invoke(8L, &num3);
				}
				llvm_lifetime_start_p0.Invoke(4L, &num4);
				num4 = syscall_impl_int_int_long_kernel_termios.Invoke(16L, fd, ts_76xnpk, &kernel_termios2);
				if (num4 < 0)
				{
					Errno_Assignment.Invoke(a: checked(-num4), @this: libc_errno.Pointer);
					result = -1;
				}
				else
				{
					result = 0;
				}
				llvm_lifetime_end_p0.Invoke(4L, &num4);
				llvm_lifetime_end_p0.Invoke(8L, &num);
				break;
			}
			llvm_lifetime_end_p0.Invoke(8L, &ts_76xnpk);
			llvm_lifetime_end_p0.Invoke(36L, &kernel_termios2);
			return result;
		}
	}
}
