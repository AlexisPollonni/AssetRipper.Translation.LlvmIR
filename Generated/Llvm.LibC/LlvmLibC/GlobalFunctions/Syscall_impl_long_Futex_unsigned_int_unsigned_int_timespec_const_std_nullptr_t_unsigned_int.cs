using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Syscall_impl_long_Futex_unsigned_int_unsigned_int_timespec_const_std_nullptr_t_unsigned_int
{
	[MangledName("_ZN19__llvm_libc_20_1_2_12syscall_implIlJPNS_5FutexEjjPK8timespecDnjEEET_lDpT0_")]
	[DemangledName("long __llvm_libc_20_1_2_::syscall_impl<long, __llvm_libc_20_1_2_::Futex*, unsigned int, unsigned int, timespec const*, std::nullptr_t, unsigned int>(long, __llvm_libc_20_1_2_::Futex*, unsigned int, unsigned int, timespec const*, std::nullptr_t, unsigned int)")]
	[return: NativeType("long")]
	public unsafe static long Invoke([MangledName("__number")][NativeType("long")] long Number, [MangledName("ts")][CleanName("Ts")][NativeType("__llvm_libc_20_1_2_::Futex*")] void* Ts_3enpke, [MangledName("ts1")][CleanName("Ts")][NativeType("unsigned int")] int Ts_76xnpk, [MangledName("ts3")][CleanName("Ts")][NativeType("unsigned int")] int Ts_w24gdx, [MangledName("ts5")][CleanName("Ts")][NativeType("timespec const*")] AuxEntry* Ts_784yyq, [MangledName("ts7")][CleanName("Ts")][NativeType("std::nullptr_t")] void* Ts_4jbuhx, [MangledName("ts9")][CleanName("Ts")][NativeType("unsigned int")] int Ts_g7c8gc)
	{
		long num = 0L;
		Llvm_lifetime_start_p0.Invoke(8L, &num);
		num = unchecked(Syscall_impl.Invoke(Number, (long)Ts_3enpke, (uint)Ts_76xnpk, (uint)Ts_w24gdx, (long)Ts_784yyq, 0L, (uint)Ts_g7c8gc));
		long result = Cpp_bit_or_static_cast_long_long.Invoke(&num);
		Llvm_lifetime_end_p0.Invoke(8L, &num);
		return result;
	}
}
