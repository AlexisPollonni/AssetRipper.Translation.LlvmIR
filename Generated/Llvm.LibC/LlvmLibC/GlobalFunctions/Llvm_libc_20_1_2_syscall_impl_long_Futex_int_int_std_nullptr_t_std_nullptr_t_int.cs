using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Llvm_libc_20_1_2_syscall_impl_long_Futex_int_int_std_nullptr_t_std_nullptr_t_int
{
	[MangledName("_ZN19__llvm_libc_20_1_2_12syscall_implIlJPNS_5FutexEiiDnDniEEET_lDpT0_")]
	[DemangledName("long __llvm_libc_20_1_2_::syscall_impl<long, __llvm_libc_20_1_2_::Futex*, int, int, std::nullptr_t, std::nullptr_t, int>(long, __llvm_libc_20_1_2_::Futex*, int, int, std::nullptr_t, std::nullptr_t, int)")]
	[return: NativeType("long")]
	public unsafe static long Invoke([MangledName("__number")][NativeType("long")] long Number, [MangledName("ts")][CleanName("Ts")][NativeType("__llvm_libc_20_1_2_::Futex*")] void* Ts_3enpke, [MangledName("ts1")][CleanName("Ts")][NativeType("int")] int Ts_76xnpk, [MangledName("ts3")][CleanName("Ts")][NativeType("int")] int Ts_w24gdx, [MangledName("ts5")][CleanName("Ts")][NativeType("std::nullptr_t")] void* Ts_784yyq, [MangledName("ts7")][CleanName("Ts")][NativeType("std::nullptr_t")] void* Ts_4jbuhx, [MangledName("ts9")][CleanName("Ts")][NativeType("int")] int Ts_g7c8gc)
	{
		long num = 0L;
		Llvm_lifetime_start_p0.Invoke(8L, &num);
		num = Llvm_libc_20_1_2_syscall_impl.Invoke(Number, unchecked((long)Ts_3enpke), Ts_76xnpk, Ts_w24gdx, 0L, 0L, Ts_g7c8gc);
		long result = Cpp_bit_or_static_cast_long_long.Invoke(&num);
		Llvm_lifetime_end_p0.Invoke(8L, &num);
		return result;
	}
}
