using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.InlineArrays;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Tcsetattr
{
	[MangledName("tcsetattr")]
	[DemangledName("tcsetattr")]
	public unsafe static int Invoke([MangledName("fd")] int Fd, [MangledName("actions")] int Actions, [MangledName("t")] Termios* T)
	{
		Llvm_libc_20_1_2_kernel_termios llvm_libc_20_1_2_kernel_termios = default(Llvm_libc_20_1_2_kernel_termios);
		long ts_76xnpk = 0L;
		long num = 0L;
		long num2 = 0L;
		long num3 = 0L;
		int num4 = 0;
		Llvm_lifetime_start_p0.Invoke(36L, &llvm_libc_20_1_2_kernel_termios);
		Llvm_memset_p0_i64.Invoke(&llvm_libc_20_1_2_kernel_termios, -86, 36L, isVolatile: false);
		Llvm_lifetime_start_p0.Invoke(8L, &ts_76xnpk);
		ts_76xnpk = -6148914691236517206L;
		unchecked
		{
			int result;
			switch (Actions)
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
					Errno_Assignment.Invoke(Llvm_libc_20_1_2_libc_errno.Pointer, 22);
					result = -1;
					break;
				}
				IL_00a9:
				llvm_libc_20_1_2_kernel_termios.C_iflag = T->C_iflag;
				llvm_libc_20_1_2_kernel_termios.C_oflag = T->C_oflag;
				llvm_libc_20_1_2_kernel_termios.C_cflag = T->C_cflag;
				llvm_libc_20_1_2_kernel_termios.C_lflag = T->C_lflag;
				Llvm_lifetime_start_p0.Invoke(8L, &num);
				num = 19L;
				Llvm_lifetime_start_p0.Invoke(8L, &num2);
				for (num2 = 0L; (ulong)num2 < (ulong)num; num2++)
				{
					sbyte b = ((sbyte*)(&T->C_cc))[num2];
					Unsafe.As<InlineArray19_SByte, sbyte>(ref Unsafe.AddByteOffset(ref llvm_libc_20_1_2_kernel_termios.C_cc, (nint)num2)) = b;
				}
				Llvm_lifetime_end_p0.Invoke(8L, &num2);
				if ((ulong)num < 19uL)
				{
					Llvm_lifetime_start_p0.Invoke(8L, &num3);
					for (num3 = num; (ulong)num3 < 19uL; num3++)
					{
						Unsafe.As<InlineArray19_SByte, sbyte>(ref Unsafe.AddByteOffset(ref llvm_libc_20_1_2_kernel_termios.C_cc, (nint)num3)) = 0;
					}
					Llvm_lifetime_end_p0.Invoke(8L, &num3);
				}
				Llvm_lifetime_start_p0.Invoke(4L, &num4);
				num4 = Llvm_libc_20_1_2_syscall_impl_int_int_long_kernel_termios.Invoke(16L, Fd, ts_76xnpk, &llvm_libc_20_1_2_kernel_termios);
				if (num4 < 0)
				{
					Errno_Assignment.Invoke(A: checked(-num4), This: Llvm_libc_20_1_2_libc_errno.Pointer);
					result = -1;
				}
				else
				{
					result = 0;
				}
				Llvm_lifetime_end_p0.Invoke(4L, &num4);
				Llvm_lifetime_end_p0.Invoke(8L, &num);
				break;
			}
			Llvm_lifetime_end_p0.Invoke(8L, &ts_76xnpk);
			Llvm_lifetime_end_p0.Invoke(36L, &llvm_libc_20_1_2_kernel_termios);
			return result;
		}
	}
}
