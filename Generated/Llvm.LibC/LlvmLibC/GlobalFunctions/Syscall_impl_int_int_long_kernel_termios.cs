using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Syscall_impl_int_int_long_kernel_termios
{
	[MangledName("_ZN19__llvm_libc_20_1_2_12syscall_implIiJilPNS_14kernel_termiosEEEET_lDpT0_")]
	[DemangledName("int __llvm_libc_20_1_2_::syscall_impl<int, int, long, __llvm_libc_20_1_2_::kernel_termios*>(long, int, long, __llvm_libc_20_1_2_::kernel_termios*)")]
	[return: NativeType("int")]
	public unsafe static int Invoke([MangledName("__number")][NativeType("long")] long Number, [MangledName("ts")][CleanName("Ts")][NativeType("int")] int Ts_3enpke, [MangledName("ts1")][CleanName("Ts")][NativeType("long")] long Ts_76xnpk, [MangledName("ts3")][CleanName("Ts")][NativeType("__llvm_libc_20_1_2_::kernel_termios*")] Kernel_termios* Ts_w24gdx)
	{
		long num = 0L;
		Llvm_lifetime_start_p0.Invoke(8L, &num);
		num = Syscall_impl.Invoke(Number, Ts_3enpke, Ts_76xnpk, unchecked((long)Ts_w24gdx));
		int result = Cpp_bit_or_static_cast_int_long.Invoke(&num);
		Llvm_lifetime_end_p0.Invoke(8L, &num);
		return result;
	}
}
