using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.InlineArrays;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Tcgetattr
{
	[MangledName("tcgetattr")]
	[DemangledName("tcgetattr")]
	public unsafe static int Invoke([MangledName("fd")] int Fd, [MangledName("t")] Termios* T)
	{
		Llvm_libc_20_1_2_kernel_termios llvm_libc_20_1_2_kernel_termios = default(Llvm_libc_20_1_2_kernel_termios);
		int num = 0;
		long num2 = 0L;
		long num3 = 0L;
		long num4 = 0L;
		Llvm_lifetime_start_p0.Invoke(36L, &llvm_libc_20_1_2_kernel_termios);
		Llvm_memset_p0_i64.Invoke(&llvm_libc_20_1_2_kernel_termios, -86, 36L, isVolatile: false);
		Llvm_lifetime_start_p0.Invoke(4L, &num);
		num = Llvm_libc_20_1_2_syscall_impl_int_int_int_kernel_termios.Invoke(16L, Fd, 21505, &llvm_libc_20_1_2_kernel_termios);
		int result;
		if (num < 0)
		{
			Errno_Assignment.Invoke(A: -num, This: Llvm_libc_20_1_2_libc_errno.Pointer);
			result = -1;
		}
		else
		{
			T->C_iflag = llvm_libc_20_1_2_kernel_termios.C_iflag;
			T->C_oflag = llvm_libc_20_1_2_kernel_termios.C_oflag;
			T->C_cflag = llvm_libc_20_1_2_kernel_termios.C_cflag;
			T->C_lflag = llvm_libc_20_1_2_kernel_termios.C_lflag;
			T->C_ispeed = llvm_libc_20_1_2_kernel_termios.C_cflag & 0x100F;
			T->C_ospeed = llvm_libc_20_1_2_kernel_termios.C_cflag & 0x100F;
			Llvm_lifetime_start_p0.Invoke(8L, &num2);
			num2 = 19L;
			Llvm_lifetime_start_p0.Invoke(8L, &num3);
			unchecked
			{
				for (num3 = 0L; (ulong)num3 < (ulong)num2; num3++)
				{
					sbyte b = Unsafe.As<InlineArray19_SByte, sbyte>(ref Unsafe.AddByteOffset(ref llvm_libc_20_1_2_kernel_termios.C_cc, (nint)num3));
					((sbyte*)(&T->C_cc))[num3] = b;
				}
				Llvm_lifetime_end_p0.Invoke(8L, &num3);
				if (32uL > (ulong)num2)
				{
					Llvm_lifetime_start_p0.Invoke(8L, &num4);
					for (num4 = num2; (ulong)num4 < 32uL; num4++)
					{
						((sbyte*)(&T->C_cc))[num4] = 0;
					}
					Llvm_lifetime_end_p0.Invoke(8L, &num4);
				}
				result = 0;
				Llvm_lifetime_end_p0.Invoke(8L, &num2);
			}
		}
		Llvm_lifetime_end_p0.Invoke(4L, &num);
		Llvm_lifetime_end_p0.Invoke(36L, &llvm_libc_20_1_2_kernel_termios);
		return result;
	}
}
